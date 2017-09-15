using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TxOnesmargin
 {


 public  decimal? Marginid { get; set; }

 public  decimal? Transactionid { get; set; }

 public  decimal? Agencyid { get; set; }

 public  decimal? Marginamount { get; set; }

 public  string Remarks { get; set; }

 public  string Status { get; set; }

}
