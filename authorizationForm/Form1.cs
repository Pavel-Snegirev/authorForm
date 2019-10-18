using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace authorizationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        string name = "";
        string soname = "";
        string work = "";
        string emailAdress = "";
        string regKey = "";




        //функция отправки сообщения
       //private void SendMessage()
       // {
       //     //отправитель -устанавоиваем почту оправления, можно указать свой email, или в качестве параметра передать данные email с формы
       //     MailAddress From = new MailAddress("---------", "Приложение"); // второй параметр указывает на имя отправителя
       //     // кому отправляем - вводим адрес почты, на который хотим получать сообщение
       //     MailAddress To = new MailAddress("-------------");
       //     // создаем объект сообщения
       //     MailMessage msg = new MailMessage(From, To);
       //     //тема письма
       //     msg.Subject = "Регистрация приложения";

       //     //текст письма
       //     msg.Body = "Имя: " + name + "<br />" + "Фамилия: " + soname + "<br />" + "Организация: " + work + "<br />" + "Email: " + emailAdress + "<br />" + "RegKey: " + regKey;

       //     //html теги в письме
       //     msg.IsBodyHtml = true;

       //     //создаем адрес smtp сервера, в качестве параметров задаем сервер и порт
       //     SmtpClient smtp = new SmtpClient("--------", 587);
       //     // Передаем параметры почты отправителя адрес и пароль
       //     smtp.Credentials = new NetworkCredential("--------", "----------");
       //     smtp.EnableSsl = true;
       //     // отправляем письмо
       //     smtp.Send(msg);




       // }
        // отправка данных только при условии всех введенных полей
        private void SendMail()
        {
            
            
                if (regKey == "00000")
                {
                    if (soname != "")
                    {
                        if (work != "")
                        {
                            if (emailAdress != "")
                            {
                            if (name != "") 

                            {
                               
                            
                                if (checkBox1.Checked == true)
                                {

                                    //SendMessage();
                                    MessageBox.Show("Приложение успешно активированно");
                                    Form2 fr = new Form2();
                                    fr.Show();
                                    this.Visible = false;
                                   
                                    


                                }
                            }
                            }
                        }
                    }
                }

            if (regKey != "00000")
            {
                label2.Visible = false;
                MessageBox.Show("Введен не верно регистрационный ключ");
            }
                if (checkBox1.Checked == false) MessageBox.Show("Примите лицензионное соглашение");




        }

        private void FullMail()
        {

            if (name != "") bunifuMaterialTextbox1.BackColor = Color.White;

            if (soname != "") bunifuMaterialTextbox2.BackColor = Color.White;

            if (work != "") bunifuMaterialTextbox3.BackColor = Color.White;

            if (emailAdress != "") bunifuMaterialTextbox4.BackColor = Color.White;

            if (regKey != "") bunifuMaterialTextbox5.BackColor = Color.White;

            switch (name)
            {
                case "":
                    bunifuMaterialTextbox1.BackColor = Color.Red;
                    label2.Visible = true;
                   

                    break;
                case "Введите ваше имя":
                    bunifuMaterialTextbox1.BackColor = Color.Red;
                    label2.Visible = true;
                   
                    break;

            }
            switch (soname)
            {
                case "":
                    bunifuMaterialTextbox2.BackColor = Color.Red;
                    label2.Visible = true;
                   
                    break;
                case "Фамилия":
                    bunifuMaterialTextbox2.BackColor = Color.Red;
                    label2.Visible = true;
                   
                    break;

            }

            switch (work)
            {
                case "":
                    bunifuMaterialTextbox4.BackColor = Color.Red;
                    label2.Visible = true;
                   
                    break;
                case "Организация":
                    bunifuMaterialTextbox4.BackColor = Color.Red;
                    label2.Visible = true;
                   
                    break;
               

            }

            switch (emailAdress)
            {
                case "":
                    bunifuMaterialTextbox3.BackColor = Color.Red;
                    label2.Visible = true;
                                       break;
                case "Email":
                    bunifuMaterialTextbox3.BackColor = Color.Red;
                    label2.Visible = true;
                   
                    break;
            }

            switch (regKey)
            {
                case "":
                    bunifuMaterialTextbox5.BackColor = Color.Red;
                    label2.Visible = true;
                   
                    break;
                case "Регистрационный ключ":
                    bunifuMaterialTextbox5.BackColor = Color.Red;
                    label2.Visible = true;
                   
                    break;

            }




           
           
        }
        private void Label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        


        private void BunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            name = bunifuMaterialTextbox1.Text;
            
            
        }

        private void BunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
            {
                soname = bunifuMaterialTextbox2.Text;
            }

        private void BunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
            {
                work = bunifuMaterialTextbox4.Text;
            }

        private void BunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
            {
                emailAdress = bunifuMaterialTextbox3.Text;
            }

        private void BunifuMaterialTextbox5_OnValueChanged(object sender, EventArgs e)
            {
                regKey = bunifuMaterialTextbox5.Text;
            }


        private void Button1_Click(object sender, EventArgs e)
        {

            SendMail(); // отправка сообщения   
            FullMail();  // проверка заполнения всех полей



        }

       
    }
}
