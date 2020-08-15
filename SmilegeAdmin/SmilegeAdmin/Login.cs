using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SmilegeAdmin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //php연결하는거
        private String Login_php() 
        {
            String result;
            String callUrl = "http://smilelig.sshworld.me/api/admin/login.php";
            String[] data = new String[2];
            data[0] = Admin_ID.Text;         // id
            data[1] = Admin_PW.Text;          // pw

            try
            {
                String postData = String.Format("USER_ID={0} & USER_PW={1}", data[0], data[1]);
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(callUrl);

                // 인코딩 UTF-8
                byte[] sendData = UTF8Encoding.UTF8.GetBytes(postData);
                httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                httpWebRequest.Method = "POST";
                httpWebRequest.ContentLength = sendData.Length;
                Stream requestStream = httpWebRequest.GetRequestStream();
                requestStream.Write(sendData, 0, sendData.Length);
                requestStream.Close();
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
                result = streamReader.ReadToEnd();
                streamReader.Close();
                httpWebResponse.Close();

                //성공했는지 못했는지 판별
                MessageBox.Show("result: " + result);
            }
            catch (Exception e)
            {
                MessageBox.Show("error " + e);
                result = null;
            }

            return result;

        }

       /* 학생 정보 받아오는거  
         private String studentInfo()
        {
            String result;
            String callUrl = "http://smilelig.sshworld.me/api/admin/studentInfo.php";

            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(callUrl);

                // 인코딩 UTF-8
                httpWebRequest.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
                result = streamReader.ReadToEnd();
                streamReader.Close();
                httpWebResponse.Close();

                //성공했는지 못했는지 판별
                MessageBox.Show("result: " + result);
            }
            catch (Exception e)
            {
                MessageBox.Show("error " + e);
                result = null;
            }

            return result;

        }
       */

        private void Button_AdminLogin_Click(object sender, EventArgs e)
        {
            /*
             String longin_php = studentInfo();
            if (longin_php == null)
            {
                MessageBox.Show("error_연결안됨");
            }
            else
            {
                JObject login_O = JObject.Parse(longin_php);
                //Boolean login_Check = login_O.Value<Boolean>("success");
                //String User_name = login_O.Value<string>("USER_NAME");

                JArray jArray = new JArray(login_O);

                foreach(var user in jArray)
                {
                    MessageBox.Show(user.Value<string>("USER_ID"));
                    MessageBox.Show(user.Value<string>("USER_PW"));

                }
            */



            //로그인
            String longin_php = Login_php();
            if (longin_php == null)
            {
                MessageBox.Show("error_연결안됨");
            }
            else
            {
                JObject login_O = JObject.Parse(longin_php);
                Boolean login_Check = login_O.Value<Boolean>("success");
                String User_name = login_O.Value<string>("USER_NAME");
                if (login_Check)
                {
                    //확인용
                    //MessageBox.Show("User_name" + User_name);
                    MessageBox.Show("로그인에 성공하였습니다.", "성공");
                    this.Visible = false;
                    SmilegeManage smilegemanage = new SmilegeManage();
                    smilegemanage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("로그인에 실패하였습니다.", "에러");
                }
            }
        }


    }
}
