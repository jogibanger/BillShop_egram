using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TxQueryincidentresponse
 {


 public  decimal? Incidentid { get; set; }

 public  decimal? Responseid { get; set; }

 public  string Responsetext { get; set; }

 public  string Status { get; set; }

 public  DateTime? Responsedate { get; set; }

 public  string Responseby { get; set; }

}
