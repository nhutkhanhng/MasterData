// <auto-generated />
#pragma warning disable CS0105
using MasterMemory.Tests;
using MasterMemory.Validation;
using MasterMemory;
using MessagePack;
using System.Collections.Generic;
using System;

namespace MasterData.Tables
{
   public sealed partial class SkillMasterTable : TableBase<SkillMaster>, ITableUniqueValidate
   {
        public Func<SkillMaster, (int SkillId, int SkillLevel)> PrimaryKeySelector => primaryIndexSelector;
        readonly Func<SkillMaster, (int SkillId, int SkillLevel)> primaryIndexSelector;


        public SkillMasterTable(SkillMaster[] sortedData)
            : base(sortedData)
        {
            this.primaryIndexSelector = x => (x.SkillId, x.SkillLevel);
            OnAfterConstruct();
        }

        partial void OnAfterConstruct();


        public SkillMaster FindBySkillIdAndSkillLevel((int SkillId, int SkillLevel) key)
        {
            return FindUniqueCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<(int SkillId, int SkillLevel)>.Default, key, true);
        }
        
        public bool TryFindBySkillIdAndSkillLevel((int SkillId, int SkillLevel) key, out SkillMaster result)
        {
            return TryFindUniqueCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<(int SkillId, int SkillLevel)>.Default, key, out result);
        }

        public SkillMaster FindClosestBySkillIdAndSkillLevel((int SkillId, int SkillLevel) key, bool selectLower = true)
        {
            return FindUniqueClosestCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<(int SkillId, int SkillLevel)>.Default, key, selectLower);
        }

        public RangeView<SkillMaster> FindRangeBySkillIdAndSkillLevel((int SkillId, int SkillLevel) min, (int SkillId, int SkillLevel) max, bool ascendant = true)
        {
            return FindUniqueRangeCore(data, primaryIndexSelector, System.Collections.Generic.Comparer<(int SkillId, int SkillLevel)>.Default, min, max, ascendant);
        }


        void ITableUniqueValidate.ValidateUnique(ValidateResult resultSet)
        {
            ValidateUniqueCore(data, primaryIndexSelector, "(SkillId, SkillLevel)", resultSet);       
        }

        public static MasterMemory.Meta.MetaTable CreateMetaTable()
        {
            return new MasterMemory.Meta.MetaTable(typeof(SkillMaster), typeof(SkillMasterTable), "skillmaster",
                new MasterMemory.Meta.MetaProperty[]
                {
                    new MasterMemory.Meta.MetaProperty(typeof(SkillMaster).GetProperty("SkillId")),
                    new MasterMemory.Meta.MetaProperty(typeof(SkillMaster).GetProperty("SkillLevel")),
                    new MasterMemory.Meta.MetaProperty(typeof(SkillMaster).GetProperty("AttackPower")),
                    new MasterMemory.Meta.MetaProperty(typeof(SkillMaster).GetProperty("SkillName")),
                    new MasterMemory.Meta.MetaProperty(typeof(SkillMaster).GetProperty("Description")),
                },
                new MasterMemory.Meta.MetaIndex[]{
                    new MasterMemory.Meta.MetaIndex(new System.Reflection.PropertyInfo[] {
                        typeof(SkillMaster).GetProperty("SkillId"),
                        typeof(SkillMaster).GetProperty("SkillLevel"),
                    }, true, true, System.Collections.Generic.Comparer<(int SkillId, int SkillLevel)>.Default),
                });
        }

    }
}