//Christos Kokkalis 2020, input validation and button logic

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e) { }
        public bool validate()
        {
            bool flag;
            if (txtFirstNumber.Text == "" || txtSecondNumber.Text == "")
            {
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    txtResult.Text = String.Format($"{int.Parse(txtFirstNumber.Text) + int.Parse(txtSecondNumber.Text)}");
                    lblMessage.Text = "";
                }
                else
                {
                    lblMessage.Text = "You are missing a number!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
        protected void btnSubtract_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    txtResult.Text = String.Format($"{int.Parse(txtFirstNumber.Text) - int.Parse(txtSecondNumber.Text)}");
                    lblMessage.Text = "";
                }
                else
                {
                    lblMessage.Text = "You are missing a number!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    txtResult.Text = String.Format($"{int.Parse(txtFirstNumber.Text) * int.Parse(txtSecondNumber.Text)}");
                    lblMessage.Text = "";
                }
                else
                {
                    lblMessage.Text = "You are missing a number!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
        protected void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                if (validate())
                {
                    txtResult.Text = String.Format($"{int.Parse(txtFirstNumber.Text) / int.Parse(txtSecondNumber.Text)}");
                    lblMessage.Text = "";
                }
                else
                {
                    lblMessage.Text = "You are missing a number!";
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = ex.Message;
            }
        }
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Text = "";
            txtSecondNumber.Text = "";
            txtResult.Text = "";
        }
    }
}