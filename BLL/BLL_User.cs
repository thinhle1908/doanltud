using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class BLL_User
    {
        DAL_User dal_User = new DAL_User();

        public int login (clsUser user)
        {
            DataTable dt = new DataTable();
            dt = dal_User.login(user);


            if (dt.Rows.Count > 0)
            {
                if (int.Parse(dt.Rows[0][3].ToString()) == 1)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            { 
                return 3; 
            }

        }
        public int getID(clsUser user)
        {
            DataTable dt = new DataTable();
            dt = dal_User.login(user);


            if (dt.Rows.Count > 0)
            {
                return int.Parse(dt.Rows[0][0].ToString());
            }
            return 100;
        }
        public int createUser(string sTenDangNhap,string sMatKhau)
        {
            clsUser user  =  new clsUser(sTenDangNhap,sMatKhau);
            return dal_User.createUser(user);
        }
        public int deleteUser( string MASV)
        {
            int iKetQua = 0;
            try
            {
                iKetQua = dal_User.deleteUser(MASV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return iKetQua;
        }
        public int changePassword(string username,string oldpassword,string newpassword)
        {
            clsUser user = new clsUser(username.Trim(), oldpassword.Trim());
            DataTable dt = new DataTable();
            dt = dal_User.login(user);
            if (dt.Rows.Count > 0)
            {
                user.Password = newpassword;
                return dal_User.changePassword(user);
            }
            return 2;
        }

    }
}
