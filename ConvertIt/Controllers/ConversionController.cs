﻿using ConvertIt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using ConvertIt.Services;

namespace ConvertIt.Controllers
{
    public class ConversionController : Controller
    {
        public ConversionService ConversionService = new ConversionService();

        public ActionResult Index()
        {
            ConversionModel conversions = new ConversionModel();
            return View(conversions);
        }

        public JsonResult CalculateCurrency(int input, string from, string to)
        {
            double currency = ConversionService.GetCurrency(input, from, to);
            return Json(currency, JsonRequestBehavior.AllowGet);

        }
        public JsonResult CalculateLength(int input, string from, string to)
        {
            double length = ConversionService.GetLength(input, from, to);
            return Json(Math.Round(length, 12), JsonRequestBehavior.AllowGet);
        }

        public JsonResult CalculateTemperature(int input, string from, string to)
        {
            double temp = ConversionService.GetTemperature(input, from, to);
            return Json(Math.Round(temp, 12), JsonRequestBehavior.AllowGet);
        }

        public JsonResult CalculateTime(int input, string from, string to)
        {
            double time = ConversionService.GetTime(input, from, to);
            return Json(Math.Round(time, 12), JsonRequestBehavior.AllowGet);
        }
        public JsonResult CalculateWeight(int input, string from, string to)
        {
            double weight = ConversionService.GetWeight(input, from, to);
            return Json(Math.Round(weight, 12), JsonRequestBehavior.AllowGet);
        }
    }
}