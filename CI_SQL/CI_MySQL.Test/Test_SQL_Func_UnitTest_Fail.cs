using CI_SQL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Conn.SQL.Test
{
    [TestClass]
    public class Test_SQL_Func_UnitTest_Fail
    {
        [TestMethod]
        public void The_Member_is_corrct_to_edited ()
        {
            //Arrange
            string BeginName = "test";
            string BeginName1 = "test123";
            string BeginPWD = "6789";
            string Test_PWD_Correct = "9999";
            string Test_PWD_Wrong = "6666";
            int BeginLev = 55688;

            //Act
            Conn_SQL.del_member(BeginName);
            Conn_SQL.Add_member(BeginName, BeginPWD, BeginLev);
            Conn_SQL.Change_pwd(BeginName, "9999");


            //Assert
            string ans;
            ans = Conn_SQL.Get_data(BeginName);
            Assert.AreEqual(Test_PWD_Correct, ans);



            //string Ans;
            //Ans = Conn_sql.Get_data(BeginName1);

            //if (Ans == Test_PWD_Correct)
            //{
            //    Console.WriteLine("Correct!!");
            //}
            //else
            //{
            //    Console.WriteLine("Wrong!!!!!!!!!!!!!!!");
            //}

        }
    }
}
