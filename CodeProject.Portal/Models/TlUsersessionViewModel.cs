using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TlUsersession
 {


 public  decimal? Sessionid { get; set; }

 public  decimal? Userid { get; set; }

 public  string Ipaddress { get; set; }

 public  DateTime? Startdatetime { get; set; }

 public  DateTime? Enddatetime { get; set; }

 public  Int32? Status { get; set; }

 public  string Hashpwd { get; set; }

}
