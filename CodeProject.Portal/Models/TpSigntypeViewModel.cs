using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TpSigntype
 {


 public  Int32? Signtypeid { get; set; }

 public  string Description { get; set; }

 public  decimal? Signonfee { get; set; }

 public  decimal? Dsmargin { get; set; }

 public  decimal? Mdsmargin { get; set; }

}
