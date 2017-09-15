using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmServiceagencymap
 {


 public  Int32? Serviceid { get; set; }

 public  Int32? Agencyid { get; set; }

 public  string Serviceinfo1 { get; set; }

 public  string Serviceinfo2 { get; set; }

 public  string Serviceinfo3 { get; set; }

 public  string Serviceinfo4 { get; set; }

 public  string Serviceinfo5 { get; set; }

 public  string Txnfeetype { get; set; }

 public  decimal? Txnfeevalue { get; set; }

 public  string Marginfromagencytype { get; set; }

 public  decimal? Marginfromagencyvalue { get; set; }

 public  string Status { get; set; }

}
