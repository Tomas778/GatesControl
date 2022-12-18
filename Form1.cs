using GatesControl.DBconfig;
using GatesControl.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Windows.Forms;

namespace GatesControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        #region Create Gates and Workers with releation
        private void WriteDB_Click(object sender, EventArgs e)
        {
            var MainGate = new Gate
            {
                Name = "Main Entrance",
                Code = "MAIN"
            };
            var SmokingGate = new Gate
            {
                Name = "Smoking Area",
                Code = "SMOKING"
            };
            var LunchGate = new Gate
            {
                Name = "Lunch Area",
                Code = "LUNCH"
            };
            var StuffGate = new Gate
            {
                Name = "Stuff Only",
                Code = "STUFF"
            };

            using (var ctx = new DataContext())
            {

                ctx.Workers.Add(new Worker
                {
                    Name = "Jonas Benaitis",
                    Code = "JOBE",
                    Gates = new List<Gate>
                    {
                        MainGate,
                    }
                });
                ctx.Workers.Add(new Worker
                {
                    Name = "Saulius Prusaitis",
                    Code = "SAPR",
                    Gates = new List<Gate>
                    {
                        StuffGate
                    }
                });
                ctx.Workers.Add(new Worker
                {
                    Name = "Sigis Sigitas",
                    Code = "SIGI",
                    Gates = new List<Gate>
                    {
                        SmokingGate,
                        LunchGate,
                    }
                });
                ctx.Workers.Add(new Worker
                {
                    Name = "Bronius Kentas",
                    Code = "BRKE",
                    Gates = new List<Gate>
                    {
                        MainGate,
                        SmokingGate,
                        LunchGate,
                        StuffGate
                    }
                });
                ctx.Workers.Add(new Worker
                {
                    Name = "Juozas Semas",
                    Code = "JUSE",
                    Gates = new List<Gate>
                    {
                        MainGate,
                        SmokingGate,
                        LunchGate,
                        StuffGate
                    }
                });
                ctx.Workers.Add(new Worker
                {
                    Name = "Dalius Kentauras",
                    Code = "DAKE",
                    Gates = new List<Gate>
                    {
                        MainGate,
                        SmokingGate,
                        LunchGate,
                        StuffGate
                    }
                });
                ctx.Workers.Add(new Worker
                {
                    Name = "Titas Galvanauskas",
                    Code = "TIGA",
                    Gates = new List<Gate>
                    {
                        MainGate,
                        SmokingGate,
                        LunchGate,
                        StuffGate
                    }
                });
                ctx.Workers.Add(new Worker
                {
                    Name = "Nemantas Mantas",
                    Code = "NEMA",
                    Gates = new List<Gate>
                    {
                        MainGate,
                        SmokingGate,
                        LunchGate,
                        StuffGate
                    }
                });
                ctx.Workers.Add(new Worker
                {
                    Name = "Tilvikas Lizdeika",
                    Code = "TILI",
                    Gates = new List<Gate>
                    {
                        MainGate,
                        SmokingGate,
                        LunchGate,
                        StuffGate
                    }
                });
                ctx.Workers.Add(new Worker
                {
                    Name = "Zigmas Benamis",
                    Code = "ZIBE",
                    Gates = new List<Gate>
                    {
                        MainGate,
                        SmokingGate,
                        LunchGate,
                        StuffGate
                    }
                });

                ctx.SaveChanges();//Save Event
                ctx.Dispose();
            }
        }
        #endregion

        #region Delete tables to start simulation from 0

        private void DeleteDB_Click(object sender, EventArgs e)
        {
            using (var ctx = new DataContext())
            {
                ctx.Gates.RemoveRange(ctx.Gates);
                ctx.Workers.RemoveRange(ctx.Workers);
                ctx.Events.RemoveRange(ctx.Events);
                ctx.SaveChanges();
                ctx.Dispose();
            }
        }
        #endregion

        #region Simulate Events for specific person and show in dataGrid
        //============ Simulate Events for specific person
        private void SimulateEvents_Click(object sender, EventArgs e)
        {
            using (var ctx = new DataContext())
            {
                //For Simulation 5 work days.
                for (int wday = 1; wday <= 5; wday++)
                {
                    //For Simulation In Out events 1-[8..9h](In), 2-[12..13h](Out), 3-[13..14h](In), 4-[14..15h](Out), 5-[16..17h](In), 6-[17..18h](Out).
                    for (int i = 1; i <= 6; i++)
                    {
                        var testGate = ctx.Gates.FirstOrDefault(x => x.Name == SelectGatesForDBsimulation.Text);
                        var testWorker = ctx.Workers.FirstOrDefault(x => x.Name == SelectWorkerForDBsimulation.Text);
                        bool actionSuccessOrNot = ctx.Entry(testGate) //TURE - success
                               .Collection(m => m.Workers)
                               .Query()
                               .Any(x => x.Id == testWorker.Id);

                        //assigns year, month, day, hour, min, seconds
                        DateTime startDate = new DateTime();

                        switch (i)  // 6 events In/Out
                        {
                            case 1:
                                startDate = new DateTime(2022, 12, wday, 8, 00, 00);
                                break;
                            case 2:
                                startDate = new DateTime(2022, 12, wday, 12, 00, 00);
                                break;
                            case 3:
                                startDate = new DateTime(2022, 12, wday, 13, 00, 00);
                                break;
                            case 4:
                                startDate = new DateTime(2022, 12, wday, 15, 00, 00);
                                break;
                            case 5:
                                startDate = new DateTime(2022, 12, wday, 15, 10, 00);
                                break;
                            case 6:
                                startDate = new DateTime(2022, 12, wday, 17, 00, 00);
                                break;
                        }

                        var randomTest = new Random(); // Random generator 

                        // Create a TimeSpan object with a specified number of hours, minutes, and seconds (~30 min random range)
                        TimeSpan timeSpan = new TimeSpan(0, 30, 0);
                        TimeSpan newSpan = new TimeSpan(0, randomTest.Next(0, (int)timeSpan.TotalMinutes), 0);
                        DateTime newDate = startDate.Add(newSpan);

                        string action;  //Logic for action In or Out

                        if (actionSuccessOrNot)
                        {
                            if (!ctx.Events.ToList().Where(x => x.WorkerId == testWorker.Id).Any())   //If Events list for specific 
                                action = "In";
                            else
                            {
                                if (ctx.Events.ToList().Last(x => x.WorkerId == testWorker.Id).Action == "In")
                                {
                                    action = "Out";
                                }
                                else
                                {
                                    action = "In";
                                }
                            }
                        }
                        else
                            action = "x"; //Not allowed trough the gates

                        ctx.Events.Add(new Event
                        {
                            TriggerTime = newDate,
                            Action = action,
                            Worker = testWorker,
                            Gate = testGate,
                            SuccessEvent = ctx.Entry(testGate)
                             .Collection(m => m.Workers)
                             .Query()
                             .Any(x => x.Id == testWorker.Id)
                        });
                        ctx.SaveChanges();//Save Event
                    }
                }

                //Update DataGrid View
                if (dataView.Rows.Count == 0)
                {
                    dataView.Columns.Add("EventTime", "EventTime");
                    dataView.Columns.Add("Action", "Action");
                    dataView.Columns.Add("Worker", "Worker");
                    dataView.Columns.Add("Gates", "Gates");
                }
                else
                {
                    dataView.Rows.Clear();
                }
                ctx.Gates.ToList();
                ctx.Workers.ToList();
                ctx.Events.ToList().ForEach(m =>
                {
                    dataView.Rows.Add(m.TriggerTime,
                                      m.Action,
                                      m.Worker.Name,
                                      m.Gate.Name);
                }
                );
                ctx.Dispose();
            }
        }
        #endregion

        #region Working Hours report and DataGrid update
        //============ Working Hours Report
        private void ReportWorkHours_Click(object sender, EventArgs e)
        {
            DateTime reportStartData = dateTimePickerStart.Value.Date + dateTimePickerStartTime.Value.TimeOfDay;
            DateTime reportEndData = dateTimePickerEnd.Value.Date + dateTimePickerEndTime.Value.TimeOfDay;
            DateTime startDate = new DateTime();
            DateTime endDate = new DateTime();
            TimeSpan workHours = new TimeSpan();

            //Count WorkingHours
            using (var ctx = new DataContext())
            {
                var testWorker = ctx.Workers.FirstOrDefault(x => x.Name == SelectorWorkerForWorkHours.Text);

                foreach (var trigger in ctx.Events.ToList())
                {
                    if (trigger.WorkerId == testWorker.Id)
                    {
                        if (trigger.Action == "In")
                        {
                            startDate = trigger.TriggerTime;
                        }
                        if (trigger.Action == "Out")
                        {
                            endDate = trigger.TriggerTime;
                            workHours += endDate - startDate;
                        }
                    }
                }

                //Show hours
                WorkHoursField.Text = $"{workHours.Hours + 24 * workHours.Days}H: {workHours.Minutes}min: {workHours.Seconds}s";

                //Update DataGrid View
                //dataView.DataSource = ctx.Events.Where(x => x.WorkerId == testWorker.Id).ToList();
                if (dataView.Rows.Count == 0)
                {
                    dataView.Columns.Add("EventTime", "EventTime");
                    dataView.Columns.Add("Action", "Action");
                    dataView.Columns.Add("Worker", "Worker");
                    dataView.Columns.Add("Gates", "Gates");
                }
                else
                {
                    dataView.Rows.Clear();
                }
                ctx.Gates.ToList();
                ctx.Workers.ToList();
                ctx.Events.Where(x => x.WorkerId == testWorker.Id).ToList().ForEach(m =>
                {
                    dataView.Rows.Add(m.TriggerTime,
                                      m.Action,
                                      m.Worker.Name,
                                      m.Gate.Name);
                }
                );
            }
        }
        #endregion

        #region Update DataGrid by trigger dateTime.
        private void ListByTime_Click(object sender, EventArgs e)
        {
            using (var ctx = new DataContext())
            {
                if (dataView.Rows.Count == 0)
                {
                    dataView.Columns.Add("EventTime", "EventTime");
                    dataView.Columns.Add("Action", "Action");
                    dataView.Columns.Add("Worker", "Worker");
                    dataView.Columns.Add("Gates", "Gates");
                }
                else
                {
                    dataView.Rows.Clear();
                }

                ctx.Gates.ToList();
                ctx.Workers.ToList();
                ctx.Events.OrderBy(x => x.TriggerTime).ToList().ForEach(m =>
                {
                    dataView.Rows.Add(m.TriggerTime,
                                      m.Action,
                                      m.Worker.Name,
                                      m.Gate.Name);
                }
                );
            }
        }
        #endregion

        #region Empty Form events, but cannot be deleted
        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectorWorker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectWorkerForDBsimulation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectGatesForDBsimulation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerStartTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerEndTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}