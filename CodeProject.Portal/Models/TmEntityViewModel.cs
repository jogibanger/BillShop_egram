using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmEntity
 {


 public  decimal? Entityid { get; set; }

 public  string Prefix { get; set; }

 public  string Firstname { get; set; }

 public  string Middlename { get; set; }

 public  string Lastname { get; set; }

 public  string Fathername { get; set; }

 public  string Mothername { get; set; }

 public  DateTime? Dateofbirth { get; set; }

 public  string Gender { get; set; }

 public  string Maritialstatus { get; set; }

 public  string Pancard { get; set; }

 public  string Companyname { get; set; }

 public  string Companyaddress1 { get; set; }

 public  string Companyaddress2 { get; set; }

 public  string Companyaddress3 { get; set; }

 public  string Companycity { get; set; }

 public  Int32? Companydistrictid { get; set; }

 public  string Companypincode { get; set; }

 public  string Companytelephone { get; set; }

 public  string Residenceaddress1 { get; set; }

 public  string Residenceaddress2 { get; set; }

 public  string Residenceaddress3 { get; set; }

 public  string Residencecity { get; set; }

 public  Int32? Residencedistrictid { get; set; }

 public  string Residencepincode { get; set; }

 public  string Residencetelephone { get; set; }

 public  bool? Addmargintolimit { get; set; }

 public  decimal? Availablelimit { get; set; }

 public  Int32? Margintypeid { get; set; }

 public  DateTime? Accorddate { get; set; }

 public  string Accountnumber { get; set; }

 public  string Ifsccode { get; set; }

 public  string Branchname { get; set; }

 public  string Bankname { get; set; }

 public  decimal? Wealthmgrid { get; set; }

 public  Int32? Addressproveid { get; set; }

 public  byte[] Addressproveimage { get; set; }

 public  Int32? Identityproveid { get; set; }

 public  byte[] Identityproveimage { get; set; }

 public  string Competitionid { get; set; }

 public  string Competitionname { get; set; }

 public  decimal? Boundlimit { get; set; }

 public  string Aadharcard { get; set; }

 public  byte[] Applicationform { get; set; }

 public  string Enrolltype { get; set; }

 public  string Spouse { get; set; }

 public  string Idproofurl { get; set; }

 public  string Addressproofurl { get; set; }

 public  string Applicationurl { get; set; }

 public  string Boondreseon { get; set; }

 public  string Bondby { get; set; }

 public  DateTime? Bonddate { get; set; }

 public  string Profileimage { get; set; }

 public  string Agreementurl { get; set; }

 public  string Outletid { get; set; }

 public  string Airtelverify { get; set; }

}
