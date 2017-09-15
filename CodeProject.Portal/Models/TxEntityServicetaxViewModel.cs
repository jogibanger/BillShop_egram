using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TxEntityServicetax
 {


 public  decimal? Marginid { get; set; }

 public  decimal? Transactionid { get; set; }

 public  decimal? Entityid { get; set; }

 public  decimal? Staxamount { get; set; }

 public  string Remarks { get; set; }

 public  string Status { get; set; }

}
