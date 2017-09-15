using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmUser
 {


 public  decimal? Userid { get; set; }

 public  string Usercode { get; set; }

 public  string Username { get; set; }

 public  string Password { get; set; }

 public  Int32? Usertype { get; set; }

 public  decimal? Parentid { get; set; }

 public  Int16? Mgrtype { get; set; }

 public  string Emailid { get; set; }

 public  string Mobile { get; set; }

 public  DateTime? Lastlogindatetime { get; set; }

 public  string Lastloginipaddress { get; set; }

 public  bool? Forcechgpwd { get; set; }

 public  string Status { get; set; }

 public  DateTime? Createddate { get; set; }

 public  string Createdby { get; set; }

 public  DateTime? Approveddate { get; set; }

 public  string Approvedby { get; set; }

 public  DateTime? Lastupdateddate { get; set; }

 public  string Lastupdatedby { get; set; }

 public  string Reason { get; set; }

 public  Int32? LoginAttempts { get; set; }

 public  bool? Agreeaccept { get; set; }

 public  string Mobotp { get; set; }

 public  bool? Otpstatus { get; set; }

 public  string Mobpwd { get; set; }

 public  string FirstOTP { get; set; }

 public  Int32? Ismobproc { get; set; }

 public  string Imino { get; set; }

 public  Int32? Istermcon { get; set; }

 public  Int32? Usercanadd { get; set; }

 public  string Dscategory { get; set; }

}
