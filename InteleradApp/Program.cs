using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InteleradApp
{
    public class OAProjects
    {
        /*Vars For All Of The OAProjects Headers*/
        public string id { get; set; }
        public string name { get; set; }
        public string acct_code { get; set; }
        public string external_id { get; set; }
        public string customer_id { get; set; }
        public string user_id { get; set; }
        public string project_location_id { get; set; }
        public string project_stage_id { get; set; }
        public string cost_center_id { get; set; }
        public string billing_contact_id { get; set; }
        public string shipping_contact_id { get; set; }
        public string notes { get; set; }
        public string recalc_warning { get; set; }
        public string currency { get; set; }
        public string budget { get; set; }
        public string budget_time { get; set; }
        public string budget_cost { get; set; }
        public string rate { get; set; }
        public string sga_labor { get; set; }
        public string start_date { get; set; }
        public string finish_date { get; set; }
        public string notify_owner { get; set; }
        public string notify_assignees { get; set; }
        public string notify_issue_assigned_to { get; set; }
        public string notify_issue_created_project_owner { get; set; }
        public string notify_issue_created_customer_owner { get; set; }
        public string notify_issue_closed_assigned_to { get; set; }
        public string notify_issue_closed_project_owner { get; set; }
        public string notify_issue_closed_customer_owner { get; set; }
        public string invoice_text { get; set; }
        public string invoice_layout_id { get; set; }
        public string te_approver { get; set; }
        public string az_approver { get; set; }
        public string ta_approver { get; set; }
        public string pr_approver { get; set; }
        public string po_approver { get; set; }
        public string br_approver { get; set; }
        public string tb_approver { get; set; }
        public string te_approvalprocess { get; set; }
        public string az_approvalprocess { get; set; }
        public string ta_approvalprocess { get; set; }
        public string pr_approvalprocess { get; set; }
        public string po_approvalprocess { get; set; }
        public string br_approvalprocess { get; set; }
        public string tb_approvalprocess { get; set; }
        public string dirty { get; set; }
        public string want_dirty { get; set; }
        public string sync_customer { get; set; }
        public string auto_bill { get; set; }
        public string auto_bill_cap { get; set; }
        public string auto_bill_cap_value { get; set; }
        public string auto_bill_override { get; set; }
        public string tax_rate_federal { get; set; }
        public string tax_rate_state { get; set; }
        public string tax_location_id { get; set; }
        public string task_budget_cost { get; set; }
        public string task_budget_revenue { get; set; }
        public string defer_recalc { get; set; }
        public string msp_link_type { get; set; }
        public string sync_workspace { get; set; }
        public string only_owner_can_edit { get; set; }
        public string user_filter { get; set; }
        public string timetype_filter { get; set; }
        public string category_filter { get; set; }
        public string assignment_cc { get; set; }
        public string billing_code { get; set; }
        public string message { get; set; }
        public string active { get; set; }
        public string deleted { get; set; }
        public string created { get; set; }
        public string updated { get; set; }
        public string notify_sr_submitted_project_owner { get; set; }
        public string sold_to_contact_id { get; set; }
        public string dashboard_from { get; set; }
        public string enable_dashboard { get; set; }
        public string attachment_id { get; set; }
        public string custom_1 { get; set; }
        public string pm_approver_1 { get; set; }
        public string pm_approver_2 { get; set; }
        public string pm_approver_3 { get; set; }
        public string payroll_type_filter { get; set; }
        public string te_allowance_approver { get; set; }
        public string te_allowance_approvalprocess { get; set; }
        public string cost_type_filter { get; set; }
        public string custom_8 { get; set; }
        public string custom_10 { get; set; }
        public string portfolio_project_id { get; set; }
        public string is_portfolio_project { get; set; }
        public string project_exclude_filter { get; set; }
        public string customer_exclude_filter { get; set; }
        public string rv_approver { get; set; }
        public string rv_approvalprocess { get; set; }
        public string custom_15 { get; set; }
        public string custom_16 { get; set; }
        public string credit_invoice_layout_id { get; set; }
        public string rate_card_id { get; set; }
        public string rm_approver { get; set; }
        public string rm_approvalprocess { get; set; }
        public string bg_approver { get; set; }
        public string bg_approvalprocess { get; set; }
        public string contact_id { get; set; }
        public string custom_17 { get; set; }
        public string custom_18 { get; set; }
        public string newsfeed_id { get; set; }
        public string custom_27 { get; set; }
        public string custom_34 { get; set; }
        public string custom_37 { get; set; }
        public string custom_38 { get; set; }
        public string custom_40 { get; set; }
        public string custom_41 { get; set; }
        public string custom_42 { get; set; }
        public string custom_43 { get; set; }
        public string custom_44 { get; set; }
        public string custom_65 { get; set; }
        public string custom_66 { get; set; }
        public string custom_68 { get; set; }
        public string custom_71 { get; set; }
        public string custom_88 { get; set; }
        public string custom_89 { get; set; }
        public string custom_90 { get; set; }
        public string custom_91 { get; set; }
        public string custom_92 { get; set; }
        public string custom_93 { get; set; }
        public string custom_94 { get; set; }
        public string custom_95 { get; set; }
        public string custom_96 { get; set; }
        public string custom_97 { get; set; }
        public string custom_98 { get; set; }
        public string custom_99 { get; set; }
        public string custom_125 { get; set; }
        public string custom_127 { get; set; }
        public string custom_133 { get; set; }
        public string custom_137 { get; set; }
        public string custom_143 { get; set; }
        public string custom_146 { get; set; }
        public string custom_150 { get; set; }
        public string custom_158 { get; set; }
        public string SNID { get; set; }
        public string OAIID { get; set; }
        public List<OAProjectTasks> OAProjectTasksListLinked { get; set; }
    }
    public class SNTimeEntries
    {
        /* Initializing All Vars For Table Entries */
        [Name("Week starts on")]
        public DateTime weekStartsOn { get; set; }
        [Name("Category")]
        public String category { get; set; }
        [Name("User")]
        public String user { get; set; }
        [Name("OA User ID")]
        public String OAUID { get; set; }
        [Name("Short description")]
        public String decription { get; set; }
        [Name("Task")]
        public String task { get; set; }
        [Name("OA Task ID")]
        public String OATID { get; set; }
        [Name("Parent")]
        public String parent { get; set; }
        [Name("OA Project ID")]
        public String OAID { get; set; }
        [Name("Client code (task)")]
        public String clientCode { get; set; }
        [Name("State")]
        public String state { get; set; }
        [Name("Total")]
        public double hoursTotal { get; set; }
        [Name("Rate type")]
        public String rateType { get; set; }
        [Name("Attribute")]
        public String attribute { get; set; }
        public DateTime dateWorked { get; set; }
        public double value { get; set; }
        public String nonBillableOA { get; set; }
        public String uniqueID { get; set; }
        public String timesheetID { get; set; }

        /* Hour Vars */
        [Name("Sunday")]
        public double hoursSunday { get; set; }
        [Name("Monday")]
        public double hoursMonday { get; set; }
        [Name("Tuesday")]
        public double hoursTuesday { get; set; }
        [Name("Wednesday")]
        public double hoursWednesday { get; set; }
        [Name("Thursday")]
        public double hoursThursday { get; set; }
        [Name("Friday")]
        public double hoursFriday { get; set; }
        [Name("Saturday")]
        public double hoursSaturday { get; set; }

    }
    public class SNTimEntriesClassMap : ClassMap<SNTimeEntries>
    {
        public SNTimEntriesClassMap()
        {
            Map(r => r.weekStartsOn).Name("Week starts on");
            Map(r => r.category).Name("Category");
            Map(r => r.user).Name("User");
            Map(r => r.OAUID).Name("OA User ID");
            Map(r => r.decription).Name("Short Description");
            Map(r => r.task).Name("Task");
            Map(r => r.OATID).Name("OA Task ID");
            Map(r => r.parent).Name("Parent");
            Map(r => r.OAID).Name("OA Project ID");
            Map(r => r.clientCode).Name("Client code (task)");
            Map(r => r.state).Name("State");
            Map(r => r.hoursTotal).Name("Total");
            Map(r => r.rateType).Name("Rate type");
            Map(r => r.attribute).Name("Attribute");
            Map(r => r.dateWorked).Name("Date worked");
            Map(r => r.value).Name("Value");
            Map(r => r.nonBillableOA).Name("Non-billable OA?");
            Map(r => r.uniqueID).Name("Unique ID");
            Map(r => r.timesheetID).Name("Timesheet ID");
            Map(r => r.hoursSunday).Ignore();
            Map(r => r.hoursMonday).Ignore();
            Map(r => r.hoursTuesday).Ignore();
            Map(r => r.hoursWednesday).Ignore();
            Map(r => r.hoursThursday).Ignore();
            Map(r => r.hoursFriday).Ignore();
            Map(r => r.hoursSaturday).Ignore();
        }
    }
    public class OAProjectTasks
    {
        /*Vars For All The OAProjectTasks Headers*/
        public string id { get; set; }
        public string customer_id { get; set; }
        public string project_id { get; set; }
        public string parent_id { get; set; }
        public string attachment_id { get; set; }
        public string cost_center_id { get; set; }
        public string projecttask_type_id { get; set; }
        public string external_id { get; set; }
        public string predecessors { get; set; }
        public string predecessors_lag { get; set; }
        public string predecessors_type { get; set; }
        public string predecessors_used { get; set; }
        public string is_a_phase { get; set; }
        public string seq { get; set; }
        public string id_number { get; set; }
        public string repeat_id { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
        public string start_date { get; set; }
        public string fnlt_date { get; set; }
        public string early_start { get; set; }
        public string early_finish { get; set; }
        public string planned_hours { get; set; }
        public string estimated_hours { get; set; }
        public string planned_days { get; set; }
        public string completed_days { get; set; }
        public string priority { get; set; }
        public string closed { get; set; }
        public string default_category { get; set; }
        public string percent_complete { get; set; }
        public string use_project_assignment { get; set; }
        public string currency { get; set; }
        public string task_budget_cost { get; set; }
        public string task_budget_revenue { get; set; }
        public string manual_task_budget { get; set; }
        public string non_billable { get; set; }
        public string ready_for_recognition { get; set; }
        public string all_can_assign { get; set; }
        public string timetype_filter { get; set; }
        public string is_critical_path { get; set; }
        public string sign_off_required { get; set; }
        public string deleted { get; set; }
        public string created { get; set; }
        public string updated { get; set; }
        public string assignment_cc { get; set; }
        public string assignment_cc_emails { get; set; }
        public string ancestry { get; set; }
        public string custom_12 { get; set; }
        public string default_category_1 { get; set; }
        public string default_category_2 { get; set; }
        public string default_category_3 { get; set; }
        public string default_category_4 { get; set; }
        public string default_category_5 { get; set; }
        public string classification { get; set; }
        public string custom_23 { get; set; }
        public string custom_24 { get; set; }
        public string custom_25 { get; set; }
        public string custom_26 { get; set; }
        public string custom_32 { get; set; }
        public string custom_67 { get; set; }
        public string custom_70 { get; set; }
        public string custom_72 { get; set; }
        public string custom_73 { get; set; }
        public string custom_74 { get; set; }
        public string custom_75 { get; set; }
        public string custom_76 { get; set; }
        public string custom_77 { get; set; }
        public string custom_102 { get; set; }
        public string custom_103 { get; set; }
        public string custom_104 { get; set; }
        public string custom_105 { get; set; }
        public string custom_106 { get; set; }
        public string custom_107 { get; set; }
        public string custom_108 { get; set; }
        public string custom_109 { get; set; }
        public string custom_110 { get; set; }
        public string custom_112 { get; set; }
        public string custom_121 { get; set; }
        public string custom_144 { get; set; }
        public string custom_145 { get; set; }
        public string custom_147 { get; set; }
        public string custom_148 { get; set; }
        public string custom_149 { get; set; }
        public string custom_153 { get; set; }
        public string custom_154 { get; set; }
        public string OATID { get; set; }
        public string OAIID { get; set; }
        public string SNID { get; set; }

    }
    public class CSVOutput
    {
        /*Initializes Lists Of Objects For Each Class*/
        public static List<SNTimeEntries> timeEntryList { get; set; }
        public static List<OAProjectTasks> OAProjectTasksList { get; set; }
        public static List<OAProjects> OAProjectsList { get; set; }

        public static void readCSV()
        {
            /*Fills all of the Lists*/
            /*Settings for Csv Reader*/
            var config = new CsvConfiguration(CultureInfo.InvariantCulture);
            config.HeaderValidated = null;
            config.MissingFieldFound = null;
            /*Gets File Paths and Loops Through All Desired Ones To Read*/
            string[] filePaths = Directory.GetFiles(Application.StartupPath);
            for(int i = 0; i < filePaths.Length; i++)
            {
                var streamReader = new StreamReader(filePaths[i]);
                var csvReader = new CsvReader(streamReader, config);
                /*You Can Change the .contains if the file format changes*/
                if (filePaths[i].Contains("SN-TimeEntries"))
                {
                    timeEntryList = csvReader.GetRecords<SNTimeEntries>().ToList();
                }
                else if (filePaths[i].Contains("OA-Project-Tasks"))
                {
                    OAProjectTasksList = csvReader.GetRecords<OAProjectTasks>().ToList();
                }
                else if (filePaths[i].Contains("OA-Projects"))
                {
                    OAProjectsList = csvReader.GetRecords<OAProjects>().ToList();
                }
                streamReader.Dispose();
                csvReader.Dispose();
            }
        }
        public static void initDataCleanup()
        {
            /* OA Projects Data Cleanup */
            List<int> tempArr2 = new List<int>();
            for (int i = 0; i < OAProjectsList.Count(); i++)
            {
                if (OAProjectsList[i].deleted == "1")
                {
                    tempArr2.Add(i);
                }
                else
                {
                    /* Trimming First Part of custom 127 identifier */
                    if (OAProjectsList[i].custom_127 != "")
                    {
                        string[] subs = OAProjectsList[i].custom_127.Split(':');
                        OAProjectsList[i].custom_127 = subs[subs.Length - 1];
                    }
                    if (OAProjectsList[i].custom_127 == " " + OAProjectsList[i].external_id)
                        OAProjectsList[i].SNID = OAProjectsList[i].external_id;
                    else if (OAProjectsList[i].custom_127 == "" || OAProjectsList[i].custom_127 == "NA")
                        OAProjectsList[i].SNID = OAProjectsList[i].external_id;
                    else if (OAProjectsList[i].external_id == "" || OAProjectsList[i].external_id == "NA")
                        OAProjectsList[i].SNID = OAProjectsList[i].custom_127;
                    else
                        OAProjectsList[i].SNID = OAProjectsList[i].external_id;
                    if (OAProjectsList[i].id != "")
                        OAProjectsList[i].OAIID = OAProjectsList[i].id;
                }
            }
            /* OA Projects Task Data Cleanup */

            for (int i = 0; i < OAProjectTasksList.Count(); i++)
            {
                if (OAProjectTasksList[i].project_id != "")
                    OAProjectTasksList[i].OAIID = OAProjectTasksList[i].project_id;
                if (OAProjectTasksList[i].custom_76 != "")
                    OAProjectTasksList[i].SNID = OAProjectTasksList[i].custom_76;
                if (OAProjectTasksList[i].id != "")
                    OAProjectTasksList[i].OATID = OAProjectTasksList[i].id;

                if (OAProjectTasksList[i].deleted == "1")
                    OAProjectTasksList.RemoveAt(i);
            }
            List<int> tempArr = new List<int>();
            for (int i = 0; i < timeEntryList.Count(); i++)
            {
                if(timeEntryList[i].hoursTotal == 0)
                {
                    tempArr.Add(i);
                }

            }
            for (int k = tempArr.Count(); k > 0; k--)
            {
                timeEntryList.RemoveAt(tempArr[k - 1]);
            }
            for (int k = tempArr2.Count(); k > 0; k--)
            {
                OAProjectsList.RemoveAt(tempArr2[k - 1]);
            }
        }

        public static void initDataLinking()
        {
            List<int> indexList = new List<int>();
            List<SNTimeEntries> listList = new List<SNTimeEntries>();
            /* Linking each OA Task w a OA Project */
            for (int i = 0; i < OAProjectsList.Count(); i++)
            {
                List<OAProjectTasks> tempList = new List<OAProjectTasks>();
                for (int j = 0; j < OAProjectTasksList.Count(); j++)
                {
                    if (OAProjectsList[i].OAIID == OAProjectTasksList[j].OAIID)
                        tempList.Add(OAProjectTasksList[j]);
                }
                OAProjectsList[i].OAProjectTasksListLinked = tempList;
            }
            /* Linking With SNTime Entry Data */
            for(int i = 0; i < timeEntryList.Count(); i++)
            {

                for (int h = 0; h < OAProjectTasksList.Count(); h++)
                {
                    if (timeEntryList[i].parent == OAProjectTasksList[h].SNID && timeEntryList[i].parent != "")
                    {
                        timeEntryList[i].OATID = OAProjectTasksList[h].OATID;
                        timeEntryList[i].OAID = OAProjectTasksList[h].OAIID;
                    }
                }
                for (int h = 0; h < OAProjectsList.Count(); h++)
                {
                    if (timeEntryList[i].parent == OAProjectsList[h].SNID && timeEntryList[i].parent != "")
                    {
                        timeEntryList[i].OAID = OAProjectsList[h].OAIID;
                        timeEntryList[i].OAUID = OAProjectsList[h].user_id;
                    }

                }
                /*Splits Hours into multiple entries*/
                if (timeEntryList[i].hoursMonday != 0)
                {
                    listList.Add(timeEntryList[i]);
                    listList[listList.Count() - 1].attribute = "Monday";
                    listList[listList.Count() - 1].dateWorked = listList[listList.Count() - 1].weekStartsOn.AddDays(1) ;
                    listList[listList.Count() - 1].value = listList[listList.Count() - 1].hoursMonday;
                    indexList.Add(i);
                }
                if (timeEntryList[i].hoursTuesday != 0)
                {
                    listList.Add(timeEntryList[i]);
                    listList[listList.Count() - 1].attribute = "Tuesday";
                    listList[listList.Count() - 1].dateWorked = listList[listList.Count() - 1].weekStartsOn.AddDays(2);
                    listList[listList.Count() - 1].value = listList[listList.Count() - 1].hoursTuesday;
                    indexList.Add(i);
                }
                if (timeEntryList[i].hoursWednesday != 0)
                {
                    listList.Add(timeEntryList[i]);
                    listList[listList.Count() - 1].attribute = "Wednesday";
                    listList[listList.Count() - 1].dateWorked = listList[listList.Count() - 1].weekStartsOn.AddDays(3);
                    listList[listList.Count() - 1].value = listList[listList.Count() - 1].hoursWednesday;
                    indexList.Add(i);
                }
                if (timeEntryList[i].hoursThursday != 0)
                {
                    listList.Add(timeEntryList[i]);
                    listList[listList.Count() - 1].attribute = "Thursday";
                    listList[listList.Count() - 1].dateWorked = listList[listList.Count() - 1].weekStartsOn.AddDays(4);
                    listList[listList.Count() - 1].value = listList[listList.Count() - 1].hoursThursday;
                    indexList.Add(i);
                }
                if (timeEntryList[i].hoursFriday != 0)
                {
                    listList.Add(timeEntryList[i]);
                    listList[listList.Count() - 1].attribute = "Friday";
                    listList[listList.Count() - 1].dateWorked = listList[listList.Count() - 1].weekStartsOn.AddDays(5);
                    listList[listList.Count() - 1].value = listList[listList.Count() - 1].hoursFriday;
                    indexList.Add(i);
                }
                if (timeEntryList[i].hoursSaturday != 0)
                {
                    listList.Add(timeEntryList[i]);
                    listList[listList.Count() - 1].attribute = "Saturday";
                    listList[listList.Count() - 1].dateWorked = listList[listList.Count() - 1].weekStartsOn.AddDays(6);
                    listList[listList.Count() - 1].value = listList[listList.Count() - 1].hoursSaturday;
                    indexList.Add(i);
                }
                if (timeEntryList[i].hoursSunday != 0)
                {
                    listList.Add(timeEntryList[i]);
                    listList[listList.Count() - 1].attribute = "Sunday";
                    listList[listList.Count() - 1].dateWorked = listList[listList.Count() - 1].weekStartsOn.AddDays(0);
                    listList[listList.Count() - 1].value = listList[listList.Count() - 1].hoursSunday;
                    indexList.Add(i);
                }
            }
            for (int i = 0; i < indexList.Count(); i++)
            {
                timeEntryList.Insert(indexList[i], listList[i]);
            }
        }
        public static void writeCSV()
        {
            /*Write to a file called Output.csv change file name below*/
            var streamWriter = new StreamWriter("Output.csv");
            var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
            csvWriter.Context.RegisterClassMap<SNTimEntriesClassMap>();
            csvWriter.WriteRecords(timeEntryList);
            csvWriter.Dispose();
            streamWriter.Dispose();
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new programForm());
        }
    }
}
