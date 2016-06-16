﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RMIS.Domain.DataTranserClass;

namespace RMIS.Domain.Business
{
    public interface IValidateTransactionBusiness
    {
        ResultDTO ValidateSellerDetails( string sellerName, string city, string district, string state, string contactNo);
        ResultDTO ValidatePaddyStockDetails(int godown, int lot, int Unitstype, int paddy, int seller, string vehicleNo, string totalbags, string price, string purchaseDate
           );
        ResultDTO ValidateRiceStockDetails(int RiceType, int RiceBrand, int UnitsType,string totalbags);
        ResultDTO ValidateBrokenRiceStockDetails(int BrokenRiceType, int UnitsType, string totalbags);
        ResultDTO ValidateDustStockDetails(int UnitsType, string totalbags);
        ResultDTO ValidateProductSellingDetails(int ProductSellingTypeId, int seller, int RiceType, int RiceBrand, int BrokenRiceType, int UnitsType, string totalbags, string price, string SellingDate);
        ResultDTO ValidateHullingProcess(int paddyType, int UnitsType, string totalbags, string ProcessBy, string ProcessDate);
        ResultDTO ValidateHullingProcessTrans(int RiceType, int BrokenRiceType, int RiceUnitsType, int BrokenRiceUnitsType,List<BrokenRiceStockDetailsDTO> listBrokenRiceStockDetailsDTO, int DustUnitsType, string Ricetotalbags, string BrokenRicetotalbags, string Dusttotalbags, string BrokenRicePrice, string DustPrice);
        ResultDTO ValidateBuyerSellerRating(int SellerID,Int16 Rating, string Remark);
        ResultDTO ValidateBuyerDetails(string BuyerName, string city, string district, string state, string contactNo);
        ResultDTO ValidateEmployeeDetails(string EmployeeName, string city, string district, string state, string contactNo);
        ResultDTO ValidateEmployeeSalary(int EmployeeName, int SalaryType, int Designation, double Salary);
        ResultDTO ValidateEmployeeSalaryPayment(int EmployeeName, int SalaryType, int Designation, double Salary, double SalaryPaid, double OTCharges);

        ResultDTO ValidateOtherExpenses(string p, string p_2, double p_3);
    }
}
