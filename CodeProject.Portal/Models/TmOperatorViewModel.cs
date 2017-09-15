using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmOperator
 {


 public  Int32? Operatorid { get; set; }

 public  string Operatorname { get; set; }

 public  string Description { get; set; }

 public  Int32? Servicetypeid { get; set; }

}
