//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Orleans.StorageProvider.Blob.Test.GrainClasses
{
    using System;
    using System.Collections.Generic;
    using System.Collections;
    using System.Runtime.Serialization;
    using Orleans.StorageProvider.Blob.Test.GrainInterfaces;
    using Orleans;
    using Orleans.Runtime;
    using Orleans.CodeGeneration;
    using System.Runtime.InteropServices;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.970.29197")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [SerializableAttribute()]
    [global::Orleans.CodeGeneration.GrainStateAttribute("Orleans.StorageProvider.Blob.Test.GrainClasses.Orleans.StorageProvider.Blob.Test." +
        "GrainClasses.Grain1")]
    public class Grain1State : global::Orleans.CodeGeneration.GrainState, MyState
    {
        

            public String StringValue { get; set; }

            public Int32 IntValue { get; set; }

            public DateTime DateTimeValue { get; set; }

            public Guid GuidValue { get; set; }

            public IGrain1 GrainValue { get; set; }

            public override void SetAll(System.Collections.Generic.IDictionary<string,object> values)
            {   
                object value;
                if (values == null) { InitStateFields(); return; }
                if (values.TryGetValue("StringValue", out value)) StringValue = (String) value;
                if (values.TryGetValue("IntValue", out value)) IntValue = value is Int64 ? (Int32)(Int64)value : (Int32)value;
                if (values.TryGetValue("DateTimeValue", out value)) DateTimeValue = (DateTime) value;
                if (values.TryGetValue("GuidValue", out value)) GuidValue = (Guid) value;
                if (values.TryGetValue("GrainValue", out value)) GrainValue = (IGrain1) value;
            }

            public override System.String ToString()
            {
                return System.String.Format("Grain1State( StringValue={0} IntValue={1} DateTimeValue={2} GuidValue={3} GrainValue={4} )", StringValue, IntValue, DateTimeValue, GuidValue, GrainValue);
            }
        
        public Grain1State() : 
                base("Orleans.StorageProvider.Blob.Test.GrainClasses.Grain1")
        {
            this.InitStateFields();
        }
        
        public override System.Collections.Generic.IDictionary<string, object> AsDictionary()
        {
            System.Collections.Generic.Dictionary<string, object> result = new System.Collections.Generic.Dictionary<string, object>();
            result["StringValue"] = this.StringValue;
            result["IntValue"] = this.IntValue;
            result["DateTimeValue"] = this.DateTimeValue;
            result["GuidValue"] = this.GuidValue;
            result["GrainValue"] = this.GrainValue;
            return result;
        }
        
        private void InitStateFields()
        {
            this.StringValue = default(String);
            this.IntValue = default(Int32);
            this.DateTimeValue = default(DateTime);
            this.GuidValue = default(Guid);
            this.GrainValue = default(IGrain1);
        }
        
        [global::Orleans.CodeGeneration.CopierMethodAttribute()]
        public static object _Copier(object original)
        {
            Grain1State input = ((Grain1State)(original));
            return input.DeepCopy();
        }
        
        [global::Orleans.CodeGeneration.SerializerMethodAttribute()]
        public static void _Serializer(object original, global::Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Grain1State input = ((Grain1State)(original));
            input.SerializeTo(stream);
        }
        
        [global::Orleans.CodeGeneration.DeserializerMethodAttribute()]
        public static object _Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Grain1State result = new Grain1State();
            result.DeserializeFrom(stream);
            return result;
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
