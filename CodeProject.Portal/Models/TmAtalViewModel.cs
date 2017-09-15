using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmAtal
 {


 public  decimal? Id { get; set; }

 public  string Accountno { get; set; }

 public  string Bankname { get; set; }

 public  string Bankbranch { get; set; }

 public  string Firstname { get; set; }

 public  string Middlename { get; set; }

 public  string Lastname { get; set; }

 public  DateTime? Dob { get; set; }

 public  string Age { get; set; }

 public  string Gender { get; set; }

 public  string Mobileno { get; set; }

 public  string Emailid { get; set; }

 public  string Aadharno { get; set; }

 public  string Taxpayer { get; set; }

 public  string Spoucename { get; set; }

 public  string Spouceaadhar { get; set; }

 public  string RealtionSubscriber { get; set; }

 public  DateTime? Nomineedob { get; set; }

 public  string Guardianname { get; set; }

 public  string Pensionamt { get; set; }

 public  string Createdby { get; set; }

 public  DateTime? Createdon { get; set; }

 public  string Lastupdateby { get; set; }

 public  DateTime? Lastupdateon { get; set; }

 public  string Status { get; set; }

 public  string Remarks { get; set; }

}
