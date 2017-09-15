using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

 public  class  TmService
 {


 public  Int32? Serviceid { get; set; }

 public  string Servicecode { get; set; }

 public  string Servicename { get; set; }

 public  string Description { get; set; }

 public  Int32? Servicetypeid { get; set; }

 public  Int32? Operatorid { get; set; }

}
