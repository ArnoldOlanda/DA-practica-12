using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;

public partial class retirement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Load content of XML file and display in GridView
        if (!Page.IsPostBack)
        {
            DataSet retirementDataSet = new DataSet();
            retirementDataSet.ReadXml(Server.MapPath("mutual_funds.xml"));
            retirementGridView.DataSource = retirementDataSet;
            retirementGridView.DataBind();
        }

    }
}
