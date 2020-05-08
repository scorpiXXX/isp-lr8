using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР7
{
    public partial class Form1 : Form
    {
        public List<People> peopleList;
        public bool openClient = false;
        public int peopleID = 0;
        public Form1()
        {
            InitializeComponent();
            peopleList = new List<People>();

            //var p = new People("Маша");

            //string name = p;
            //MessageBox.Show(name);

            //DelegateTest1();
        }
        public void UpdateInfo()
        {
            PeopleLB.Items.Clear();
            CompareCmB.Items.Clear();
            TransferCmB.Items.Clear();
            for (int i = 0; i < peopleList.Count; i++)
            {
                PeopleLB.Items.Add(peopleList[i].name + " | " + peopleList[i].money);
                CompareCmB.Items.Add(peopleList[i].name + " | " + peopleList[i].money);
                TransferCmB.Items.Add(peopleList[i].name + " | " + peopleList[i].money);
            }
        }
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (!openClient && People.IsInt(BalanceTB.Text))
            {
                string text = NameTB.Text + "[" + BalanceTB.Text + "]";
                People people = (People)text;
                peopleList.Add(people);
                NameTB.Text = "";
                BalanceTB.Text = "";
                peopleList[peopleList.Count-1].Notify += DisplayMessage;
                UpdateInfo();                
            }
            else if (openClient && People.IsInt(BalanceTB.Text))
            {
                peopleList[peopleID].name = NameTB.Text;
                peopleList[peopleID].money = Convert.ToInt32(BalanceTB.Text);
                UpdateInfo();
            }
        }
        private static void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
        //sender содержит экземпляр издателя
        //args содержит дополнительную информацию о произошедшем событии
        private void CloseBTN_Click(object sender, EventArgs e)
        {
            NameTB.Text = "";
            BalanceTB.Text = "";
            CompareCmB.Text = "";
            TransferCmB.Text = "";
            SaveBTN.Text = "Сохранить";
            CloseBTN.Visible = false;
            GetMessageBTN.Visible = false;
            GetMessageStringBTN.Visible = false;
            MessageRTB.Visible = false;
            SendMessageBTN.Visible = false;
            CompareCmB.Visible = false;
            TransferCmB.Visible = false;
            SendMoneyTB.Visible = false;
            SendMoneyBTN.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            openClient = false;
        }

        private void GetMessageBTN_Click(object sender, EventArgs e)
        {
            peopleList[peopleID].GetMessage();
        }

        private void PeopleLB_DoubleClick(object sender, EventArgs e)
        {
            int item = PeopleLB.SelectedIndex;
            if (item >= 0 && item < PeopleLB.Items.Count)
            {
                peopleID = item;
                NameTB.Text = peopleList[peopleID].name;
                BalanceTB.Text = peopleList[peopleID].money.ToString();
                SaveBTN.Text = "Изменить";
                CloseBTN.Visible = true;
                GetMessageBTN.Visible = true;
                GetMessageStringBTN.Visible = true;
                MessageRTB.Visible = true;
                SendMessageBTN.Visible = true;
                CompareCmB.Visible = true;
                TransferCmB.Visible = true;
                SendMoneyTB.Visible = true;
                SendMoneyBTN.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                openClient = true;
            }
        }

        private void GetMessageStringBTN_Click(object sender, EventArgs e)
        {
            peopleList[peopleID].GetMessageString();
        }

        private void SendMessageBTN_Click(object sender, EventArgs e)
        {
            peopleList[peopleID].SendMessage(MessageRTB.Text);
        }

        private void CompareCmB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (peopleList[peopleID] < peopleList[CompareCmB.SelectedIndex])
                MessageBox.Show("Клиент " + peopleList[peopleID].name + " имеет меньше денег, чем " + peopleList[CompareCmB.SelectedIndex].name);
            else MessageBox.Show("Клиент " + peopleList[peopleID].name + " имеет больше денег, чем " + peopleList[CompareCmB.SelectedIndex].name);
        }

        private void SendMoneyBTN_Click(object sender, EventArgs e)
        {
            if (People.IsInt(SendMoneyTB.Text))
            {
                peopleList[peopleID]  -= Convert.ToInt32(SendMoneyTB.Text);                
                peopleList[TransferCmB.SelectedIndex] += Convert.ToInt32(SendMoneyTB.Text);
                TransferCmB.Text = "";
                SendMoneyTB.Text = "";
                BalanceTB.Text = peopleList[peopleID].money.ToString();
                UpdateInfo();
            }
        }



        delegate void TestDelegate(string name);
        public void DelegateTest1()
        {
            var one = new TestDelegate(One);
            var two = new TestDelegate(Two);
            var combined = one + two;
            combined("Иван Петрович");
        }
        public void One(string name)
        {
            MessageBox.Show(name.Split(' ')[0]);
        }
        public void Two(string name)
        {
            MessageBox.Show(name.Split(' ')[1]);
        }
    }
}
