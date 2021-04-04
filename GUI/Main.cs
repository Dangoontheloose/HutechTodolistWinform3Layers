using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DTO;

namespace GUI
{
    public partial class Main : Form
    {
        int flpCurrentW;



        MainBAL bal;
        //acc ID của tài khoản được load vào Form Main (tài khoản đã đăng nhập)
        int accID;

        //số lượng task Today get & set vào label hiển thị
        public int TodayCount { get => Convert.ToInt32(lb_TodayCount.Text); set => lb_TodayCount.Text = value.ToString(); }
        //số lượng Upcoming get & set vào label hiển thị
        public int UpcomingCount { get => Convert.ToInt32(lb_UpcomingCount.Text); set => lb_UpcomingCount.Text = value.ToString(); }
        public int AllCount { get => Convert.ToInt32(lb_AllCount.Text); set => lb_AllCount.Text = value.ToString(); }
        public int DueCount { get => Convert.ToInt32(lb_DueCount.Text); set => lb_DueCount.Text = value.ToString(); }


        List<TodoTask> todayTaskList = new List<TodoTask>();
        List<TodoTask> upcomingTaskList = new List<TodoTask>();
        List<TodoTask> pastTaskList = new List<TodoTask>();
        List<TodoTask> generalTaskList = new List<TodoTask>();

        MainBAL.SortType sortType;
        //property SortType set & get dữ liệu từ combobox SortType
        public int SortType { get => cb_SortType.SelectedIndex; set => cb_SortType.SelectedIndex = value; }
        //property State set & get dữ liệu từ combobox State
        public int PanelType { get; set; }


        /// <summary>
        /// Form Main được khởi tạo với tham số accID của account đã được log in
        /// </summary>
        /// <param name="accID"></param>
        public Main(int accID)
        {
            InitializeComponent();

            this.accID = accID;
            bal = new MainBAL(accID);

            sortType = MainBAL.SortType.Priority;
            SortType = 1;
            PanelType = 0;
            //nhận giá trị width hiện tại của panel để dành cho việc resize
            flpCurrentW = flp_Today.Size.Width;
        }



        /// <summary>
        /// Hàm tạo ra các taskbox từ list và load nó vào panel tương ứng
        /// </summary>
        /// <param name="panel"></param>
        /// <param name="list"></param>
        private void CreateAndLoadTaskbox(FlowLayoutPanel panel, List<TodoTask> list)
        {
            panel.Controls.Clear();

            foreach (var item in list)
            {
                TaskBox taskBox = new TaskBox(item);
                taskBox.DoubleClick += TaskBox_DoubleClick;
                taskBox.CheckedChanged += TaskBox_CheckedChanged;
                panel.Controls.Add(taskBox);
                taskBox.Width = flpCurrentW - 10;
            }
        }

        /// <summary>
        /// Hàm load tất cả các task vào 3 panel 
        /// </summary>
        /// <param name="sortType"></param>
        /// <param name="state"></param>
        private void LoadTasksIntoPanel(MainBAL.SortType sortType = MainBAL.SortType.Default)
        {

            //mở rộng form để hiển thị cả 3 tab
            flp_Past.Show();
            flp_Upcoming.Show();
            lb_content.Text = "Today";
            todayTaskList = bal.Main_LoadList(sortType, 0);
            upcomingTaskList = bal.Main_LoadList(sortType, 1);
            pastTaskList = bal.Main_LoadList(sortType, 2);

            LoadCount();

            CreateAndLoadTaskbox(flp_Today, todayTaskList);
            CreateAndLoadTaskbox(flp_Past, pastTaskList);
            CreateAndLoadTaskbox(flp_Upcoming, upcomingTaskList);
        }


        /// <summary>
        /// Hàm load 1 loại panel cụ thể vào panel
        /// </summary>
        /// <param name="panelType"></param>
        /// <param name="sortType"></param>
        private void LoadTasksIntoPanel(int panelType, MainBAL.SortType sortType = MainBAL.SortType.Default)
        {

            //lấy dữ liệu cả 3 list today, upcoming, past vào 
            todayTaskList = bal.Main_LoadList(sortType, 0);
            upcomingTaskList = bal.Main_LoadList(sortType, 1);
            pastTaskList = bal.Main_LoadList(sortType, 2);

            //load list tương ứng với panel type vào panel đầu
            switch (panelType)
            {
                case 0:
                    generalTaskList = todayTaskList;
                    lb_content.Text = "Today";
                    break;
                case 1:
                    generalTaskList = upcomingTaskList;
                    lb_content.Text = "Upcoming";
                    break;
                case 2:
                default:
                    generalTaskList = pastTaskList;
                    lb_content.Text = "Past";
                    break;
            }

            //Hide các panel không sử dụng
            flp_Past.Hide();
            flp_Upcoming.Hide();
            lb_Upcoming.Hide();
            lb_Past.Hide();

            //reload só lượng task
            LoadCount();

            //Tạo taskbox bỏ vào panel
            CreateAndLoadTaskbox(flp_Today, generalTaskList);
        }

        /// <summary>
        /// Đếm só lượng task của mỗi list 
        /// </summary>
        private void LoadCount()
        {
            TodayCount = todayTaskList.Count;
            UpcomingCount = upcomingTaskList.Count;
            //số lượng trễ hạn có state id = 3
            DueCount = pastTaskList.Where(s => s.StateID == 3).ToList().Count;
            AllCount = TodayCount + UpcomingCount + pastTaskList.Count;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadTasksIntoPanel(PanelType, sortType);
            label3.Text = bal.LoadUserName();
        }
        /// <summary>
        /// Hàm gọi mỗi khi giá trị checkbox trên taskbox bị thay đổi => update state và reload panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskBox_CheckedChanged(object sender, EventArgs e)
        {   //chuyển event sender => taskbox
            TaskBox currentTB = sender as TaskBox;
            //update state dựa trên các thông tin từ taskbox bị thay đổi giá trị checkbox
            if (bal.Main_UpdateTaskState(currentTB.TaskboxID, currentTB.Progress, currentTB.DueDate, currentTB.FinishDate))
            {
                //reload panel
                if (PanelType == 3) { LoadTasksIntoPanel(sortType); }
                else { LoadTasksIntoPanel(PanelType, sortType); }
            }

        }
        /// <summary>
        /// Hàm gọi mỗi khi double click taskbox => mở form detail để chỉnh sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TaskBox_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Clicked "+currentTB.TaskboxID);
            //chuyển event sender => taskbox
            TaskBox currentTB = sender as TaskBox;
            //Tạo form detail mới, tham số truyền vào xác định task đc người dùng edit
            DetailForm f = new DetailForm(accID, currentTB.TaskboxID);
            //subscribe event mỗi khi task đã được update qua form detail
            f.TaskUpdated += F_TaskUpdated;

            f.Show();
        }
        /// <summary>
        /// Hàm gọi mỗi khi một task đã được update(save) qua form detail
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void F_TaskUpdated(object sender, EventArgs e)
        {
            //reload panel
            if (PanelType == 3) { LoadTasksIntoPanel(sortType); }
            else { LoadTasksIntoPanel(PanelType, sortType); }
        }


        /// <summary>
        /// Hàm gọi mỗi khi giá trị của combobox SortType bị thay đổi => reload panel theo sort type đã chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private MainBAL.SortType GetSortTypeFromCombobox()
        {
            switch (SortType)
            {
                case 0:
                    sortType = MainBAL.SortType.Default;
                    return sortType;
                case 1:
                    sortType = MainBAL.SortType.Priority;
                    return sortType;
                case 2:
                default:
                    sortType = MainBAL.SortType.DueDate;
                    return sortType;
            }
        }


        //Load cả 3 list vào 3 panel
        private void btn_All_Click(object sender, EventArgs e)
        {
            //panel type = 3 => mode load all
            PanelType = 3;
            LoadTasksIntoPanel();
        }

        private void btn_Today_Click(object sender, EventArgs e)
        {
            // panel type = 0 => mode load today
            PanelType = 0;
            LoadTasksIntoPanel(PanelType);

        }
        //Load list upcoming vào panel đầu tiên khi click
        private void btn_Upcoming_Click(object sender, EventArgs e)
        {
            //panel type = 1 => mode load upcoming
            PanelType = 1;
            LoadTasksIntoPanel(PanelType);
        }
        //Load list past vào panel đầu tiên khi click
        private void btn_Past_Click(object sender, EventArgs e)
        {
            //panel type = 2 => mode load past
            PanelType = 2;
            LoadTasksIntoPanel(PanelType);
        }

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            this.Close();
            bal.Main_LogOut();
        }
        private int ResizeAllTaskboxInPanel(FlowLayoutPanel flp)
        {
            if (flp.Size.Width == flpCurrentW)
            {
                return flpCurrentW;
            }
            else
            {
                flpCurrentW = flp.Size.Width;
                foreach (Control item in flp.Controls)
                {
                    item.Width = flpCurrentW - 10;
                }

                return flpCurrentW;
            }
        }
        //Hàm gọi khi panel today đươc resize
        private void flp_Today_Resize(object sender, EventArgs e)
        {
            flpCurrentW = ResizeAllTaskboxInPanel(flp_Today);
        }
        //Hàm gọi khi panel upcoming được resize
        private void flp_Upcoming_Resize(object sender, EventArgs e)
        {
            flpCurrentW = ResizeAllTaskboxInPanel(flp_Upcoming);
        }
        //Hàm gọi khi panel past dc resize
        private void flp_Past_Resize(object sender, EventArgs e)
        {
            flpCurrentW = ResizeAllTaskboxInPanel(flp_Past);
        }

        //Trả về SortType dựa trên lựa chọn từ combo box
        private void cb_SortType_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortType = GetSortTypeFromCombobox();
            //reload panel
            if (PanelType == 3) { LoadTasksIntoPanel(sortType); }
            else { LoadTasksIntoPanel(PanelType, sortType); }
        }
    }
}
