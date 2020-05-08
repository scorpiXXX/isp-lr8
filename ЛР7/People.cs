using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР7
{
    interface IPeople
    {
        void GetMessage();
        void GetMessageString();
        void SendMessage(string message);
    }

    class PeopleComparer : IComparer<IComparable>
    {
        public int Compare(IComparable c1, IComparable c2)
        {
            People p1 = c1 as People;
            People p2 = c2 as People;
            if (p1.name.Length > p2.name.Length)
                return 1;
            else if (p1.name.Length < p2.name.Length)
                return -1;
            else
                return 0;
        }
    }

    public class People : IPeople
    {
        public delegate void EventHandler(string message);
        public event EventHandler Notify;

        public static implicit operator string(People p) => p.name;
        public static explicit operator People(string s) => new People(s);

        //public event AccountHandler Notify2
        //{
        //    add
        //    {
        //        //Логика объединения
        //    }
        //    remove
        //    {
        //        //логика удаления
        //    }
        //}

        public string name;
        public int money;
        public People(string _name, int _money)
        {
            name = _name;
            money = _money;
        }
        public People(string text)
        {
            Regex re = new Regex(@"(?<Name>.+)\[(?<Money>\d+)\]");
            Match m = re.Match(text);

            this.name = m.Groups["Name"].Value;
            this.money = int.Parse(m.Groups["Money"].Value);
        }
        public People() { }
        public static bool IsInt(string str)
        {
            try
            {
                int num;
                bool isNum = int.TryParse(str, out num);
                if (isNum)
                    return true;
                else
                {
                    throw new Exception("Число указано в неверном формате");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void GetMessage()
        {
            MessageBox.Show("Имя: " + name + "\rБаланс: " + money);
        }

        public void GetMessageString()
        {
            MessageBox.Show("Имя: " + name + "\rБаланс: " + RusNumber.Str(money) + "рублей");
        }
        public void SendMessage(string message)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("hinna1996@mail.ru");
            mail.To.Add(new MailAddress("syscorp@mail.ru"));
            mail.Subject = "Клиент: " + name;
            mail.Body = "Баланс: " + money + "(" + RusNumber.Str(money)+ "рублей)\rСообщение:\r" + message;
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.mail.ru";
            client.Port = 587;
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("hinna1996@mail.ru".Split('@')[0], "ulbfsri48nv7");
            client.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                client.Send(mail);
                Notify?.Invoke("Сообщение успешно отправлено!");
                //MessageBox.Show("Сообщение успешно отправлено!", "Готово!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("При отправке письма произошла ошибка!\r" + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int CompareTo(IComparable o)
        {
            People p = o as People;
            if (p != null)
                return this.money.CompareTo(p.money);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
        public static People operator - (People obj, int n)
        {
            obj.money = obj.money - n;
            return obj;
        }
        public static People operator + (People obj, int n)
        {
            obj.money = obj.money + n;
            return obj;
        }
        public static People operator - (People obj, People obj2)
        {
            People p = new People();
            p.money = obj.money - obj2.money;
            return p;
        }
        public static People operator + (People obj, People obj2)
        {
            People p = new People();
            p.money = obj.money + obj2.money;
            return p;
        }
        public static bool operator > (People obj, People obj2)
        {
            if (obj.money > obj2.money)
                return true;
            return false;
        }
        public static bool operator < (People obj, People obj2)
        {
            if (obj.money < obj2.money)
                return true;
            return false;
        }

    }
}
