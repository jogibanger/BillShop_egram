using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TlImportbankcspinfo
 {


 public  decimal? Importid { get; set; }

 public  string Filename { get; set; }

 public  DateTime? Importdate { get; set; }

 public  string Importby { get; set; }

}
