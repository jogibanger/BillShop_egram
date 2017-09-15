using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmGrouprights
 {


 public  string Groupcode { get; set; }

 public  Int32? Menuid { get; set; }

 public  bool? Accessrights { get; set; }

}
