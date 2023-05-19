using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static BcasManagementSystem.Models.CommonFn;

namespace BcasManagementSystem.Admin
{
    public partial class AddClass : System.Web.UI.Page
    {
        CommonFnx fn = new CommonFnx();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetClass();
            }
        }

        private void GetClass()
        {
            DataTable dt = fn.Fetch("Select Row_NUMBER() over(Order by (Select1)) as [Sr.No],ClassId,ClassName from Class");
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = fn.Fetch("Select * from Class where ClassName='"+txtClass.Text.Trim()+"' ");
                if(dt.Rows.Count == 0)
                {
                    string query = "Insert into Class values";
                }
                else
                {

                }
            }
            catch(Exception ex)
            {

            }

        }
    }
}