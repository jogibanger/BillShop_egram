using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmDownloadcenter
 {


 public  decimal? Releaseid { get; set; }

 public  string Title { get; set; }

 public  string Description { get; set; }

 public  string Version { get; set; }

 public  string Category { get; set; }

 public  string Filename { get; set; }

 public  string Accesstousertype { get; set; }

 public  string Accesstomgrtype { get; set; }

 public  string Status { get; set; }

 public  DateTime? Createddate { get; set; }

 public  string Createdby { get; set; }

 public  DateTime? Approveddate { get; set; }

 public  string Approvedby { get; set; }

 public  DateTime? Lastupdateddate { get; set; }

 public  string Lastupdatedby { get; set; }

}
