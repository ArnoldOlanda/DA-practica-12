using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

/// <summary>
/// Summary description for Benefits
/// </summary>
public class Benefits
{
    // Custom structure containing two strings
    public struct BenefitInfo
    {
        public string benefitName;
        public string benefitPage;
    }

	public Benefits()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    // GetBenefitsList method returns an array of BenefitInfo structures
    public BenefitInfo[] GetBenefitsList()
    {
        // HttpContext.Current.Trace.IsEnabled = true;
        // HttpContext.Current.Trace.Warn
        // ("Benefits component", "Beginning of GetBenefitsList");
        BenefitInfo[] benefitsArray = new BenefitInfo[4];
        benefitsArray[0].benefitName = "Dental";
        benefitsArray[0].benefitPage = "dental.aspx";
        benefitsArray[1].benefitName = "Medical";
        benefitsArray[1].benefitPage = "medical.aspx";
        benefitsArray[2].benefitName = "Life Insurance";
        benefitsArray[2].benefitPage = "life.aspx";
        benefitsArray[3].benefitName = "Retirement Account";
        benefitsArray[3].benefitPage = "retirement.aspx";
        // HttpContext.Current.Trace.Warn
        // ("Benefits component", "End of GetBenefitsList");
        return benefitsArray;
    }

}
