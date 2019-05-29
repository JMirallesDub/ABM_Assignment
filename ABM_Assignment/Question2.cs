using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

public class Question2
{
    public static void FindNodeXML()
    {
        XmlDocument doc = new XmlDocument();

        doc.LoadXml(@"<InputDocument>
			<DeclarationList>
			  <Declaration Command='DEFAULT' Version='5.13'>
				<DeclarationHeader>
				  <Jurisdiction>IE</Jurisdiction>
				  <CWProcedure>IMPORT</CWProcedure>
				  <DeclarationDestination>CUSTOMSWAREIE</DeclarationDestination>
				  <DocumentRef>71Q0019681</DocumentRef>
				  <SiteID>DUB</SiteID>
				  <AccountCode>G0779837</AccountCode>
				  <Reference RefCode='MWB'>
					<RefText>586133622</RefText>
				  </Reference>
				  <Reference RefCode='KEY'>
					<RefText>DUB16049</RefText>
				  </Reference>
				  <Reference RefCode='CAR'>
					<RefText>71Q0019681</RefText>
				  </Reference>
				  <Reference RefCode='COM'>
					<RefText>71Q0019681</RefText>
				  </Reference>
				  <Reference RefCode='SRC'>
					<RefText>ECUS</RefText>
				  </Reference>
				  <Reference RefCode='TRV'>
					<RefText>1</RefText>
				  </Reference>
				  <Reference RefCode='CAS'>
					<RefText>586133622</RefText>
				  </Reference>
				  <Reference RefCode='HWB'>
					<RefText>586133622</RefText>
				  </Reference>
				  <Reference RefCode='UCR'>
					<RefText>586133622</RefText>
				  </Reference>
				  <Country CodeType='NUM' CountryType='Destination'>IE</Country>
				  <Country CodeType='NUM' CountryType='Dispatch'>CN</Country> 
				  </DeclarationHeader>
				</Declaration>
			</DeclarationList>
		  </InputDocument>
		");

        XmlNode MWB = doc.SelectSingleNode("/InputDocument/DeclarationList/Declaration/DeclarationHeader/Reference[@RefCode='MWB']");
        XmlNode TRV = doc.SelectSingleNode("/InputDocument/DeclarationList/Declaration/DeclarationHeader/Reference[@RefCode='TRV']");
        XmlNode CAR = doc.SelectSingleNode("/InputDocument/DeclarationList/Declaration/DeclarationHeader/Reference[@RefCode='CAR']");
        Console.WriteLine();
        Console.WriteLine("Question 2");
        Console.WriteLine("RefText values for MWB: " + MWB.InnerText);
        Console.WriteLine("RefText values for TRV: " + TRV.InnerText);
        Console.WriteLine("RefText values for CAR: " + CAR.InnerText);
    }
}