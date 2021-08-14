using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Sample
{
    // value Type
    public struct ValueType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class ReferenceType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class ValidateValueType
    {

        public void Test()
        {
            ValueType valueType1 = new ValueType();
            valueType1.Id = 10;
            valueType1.Name = "Vignesh";
            Console.WriteLine($"Step1::V1::Id::{valueType1.Id}::Name::{valueType1.Name}");

            ReferenceType referenceType1 = new ReferenceType();
            referenceType1.Id = 10;
            referenceType1.Name = "Vignesh";
            Console.WriteLine($"Step2::R1::Id::{referenceType1.Id}::Name::{referenceType1.Name}");

            ValueType valueType2 = valueType1;
            valueType2.Name = "Kumar";
            ReferenceType referenceType2 = referenceType1;
            referenceType2.Name = "Kumar";

            Console.WriteLine($"Step3::V1::Id::{valueType1.Id}::Name::{valueType1.Name}");
            Console.WriteLine($"Step4::R1::Id::{referenceType1.Id}::Name::{referenceType1.Name}");
            Console.WriteLine($"Step5::V2::Id::{valueType2.Id}::Name::{valueType2.Name}");
            Console.WriteLine($"Step6::R2::Id::{referenceType2.Id}::Name::{referenceType2.Name}");
        }
    }

}
