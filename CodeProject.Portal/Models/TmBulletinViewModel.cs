using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmBulletin
 {


 public  decimal? Bulletinid { get; set; }

 public  string Title { get; set; }

 public  DateTime? Expirydate { get; set; }

 public  string Status { get; set; }

 public  DateTime? Createddate { get; set; }

 public  string Createdby { get; set; }

 public  DateTime? Approveddate { get; set; }

 public  string Approvedby { get; set; }

 public  DateTime? Lastupdateddate { get; set; }

 public  string Lastupdatedby { get; set; }

 public  Int32? Region { get; set; }

}
