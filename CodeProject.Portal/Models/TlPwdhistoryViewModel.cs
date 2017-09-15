using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TlPwdhistory
 {


 public  decimal? Userid { get; set; }

 public  string Password { get; set; }

 public  DateTime? Modifieddate { get; set; }

 public  string Modifiedby { get; set; }

}
