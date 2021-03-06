//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(ПомощникПовара.DBContext.DataBaseContext),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets95ef69e7d596969d9f26268c608906ad1affd897a86359b199b632c4f98ae314))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework 6 Power Tools", "0.9.2.0")]
    internal sealed class ViewsForBaseEntitySets95ef69e7d596969d9f26268c608906ad1affd897a86359b199b632c4f98ae314 : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "95ef69e7d596969d9f26268c608906ad1affd897a86359b199b632c4f98ae314"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "CodeFirstDatabase.Atribut")
            {
                return GetView0();
            }

            if (extentName == "CodeFirstDatabase.AtributValuePair")
            {
                return GetView1();
            }

            if (extentName == "CodeFirstDatabase.Value")
            {
                return GetView2();
            }

            if (extentName == "CodeFirstDatabase.Result")
            {
                return GetView3();
            }

            if (extentName == "DataBaseContext.Atributs")
            {
                return GetView4();
            }

            if (extentName == "DataBaseContext.AtributValuePairs")
            {
                return GetView5();
            }

            if (extentName == "DataBaseContext.AtributValuePair_Atribut")
            {
                return GetView6();
            }

            if (extentName == "DataBaseContext.AtributValuePair_Value")
            {
                return GetView7();
            }

            if (extentName == "DataBaseContext.Result_Conditions")
            {
                return GetView8();
            }

            if (extentName == "DataBaseContext.Values")
            {
                return GetView9();
            }

            if (extentName == "DataBaseContext.Results")
            {
                return GetView10();
            }

            if (extentName == "DataBaseContext.Result_Atribut")
            {
                return GetView11();
            }

            if (extentName == "DataBaseContext.Result_Value")
            {
                return GetView12();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Atribut.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Atribut
        [CodeFirstDatabaseSchema.Atribut](T1.Atribut_Id, T1.Atribut_Name)
    FROM (
        SELECT 
            T.Id AS Atribut_Id, 
            T.Name AS Atribut_Name, 
            True AS _from0
        FROM DataBaseContext.Atributs AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.AtributValuePair.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing AtributValuePair
        [CodeFirstDatabaseSchema.AtributValuePair](T5.AtributValuePair_Id, T5.[AtributValuePair.Atribut_Id], T5.[AtributValuePair.Value_Id], T5.[AtributValuePair.Result_Id])
    FROM (
        SELECT T1.AtributValuePair_Id, T4.[AtributValuePair.Atribut_Id], T2.[AtributValuePair.Value_Id], T3.[AtributValuePair.Result_Id], (T4._from0 AND T4._from0 IS NOT NULL) AS _from0, (T2._from1 AND T2._from1 IS NOT NULL) AS _from1, (T3._from2 AND T3._from2 IS NOT NULL) AS _from2, T1._from3
        FROM  (
            SELECT 
                T.Id AS AtributValuePair_Id, 
                True AS _from3
            FROM DataBaseContext.AtributValuePairs AS T) AS T1
            LEFT OUTER JOIN (
            SELECT 
                Key(T.AtributValuePair_Value_Source).Id AS AtributValuePair_Id, 
                Key(T.AtributValuePair_Value_Target).Id AS [AtributValuePair.Value_Id], 
                True AS _from1
            FROM DataBaseContext.AtributValuePair_Value AS T) AS T2
            ON T1.AtributValuePair_Id = T2.AtributValuePair_Id
            LEFT OUTER JOIN (
            SELECT 
                Key(T.Result_Conditions_Target).Id AS AtributValuePair_Id, 
                Key(T.Result_Conditions_Source).Id AS [AtributValuePair.Result_Id], 
                True AS _from2
            FROM DataBaseContext.Result_Conditions AS T) AS T3
            ON T1.AtributValuePair_Id = T3.AtributValuePair_Id
            LEFT OUTER JOIN (
            SELECT 
                Key(T.AtributValuePair_Atribut_Source).Id AS AtributValuePair_Id, 
                Key(T.AtributValuePair_Atribut_Target).Id AS [AtributValuePair.Atribut_Id], 
                True AS _from0
            FROM DataBaseContext.AtributValuePair_Atribut AS T) AS T4
            ON T1.AtributValuePair_Id = T4.AtributValuePair_Id
    ) AS T5");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Value.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView2()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Value
        [CodeFirstDatabaseSchema.Value](T1.Value_Id, T1.Value_Name)
    FROM (
        SELECT 
            T.Id AS Value_Id, 
            T.Name AS Value_Name, 
            True AS _from0
        FROM DataBaseContext.Values AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Result.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView3()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Result
        [CodeFirstDatabaseSchema.Result](T4.Result_Id, T4.[Result.Atribut_Id], T4.[Result.Value_Id])
    FROM (
        SELECT T1.Result_Id, T3.[Result.Atribut_Id], T2.[Result.Value_Id], (T3._from0 AND T3._from0 IS NOT NULL) AS _from0, (T2._from1 AND T2._from1 IS NOT NULL) AS _from1, T1._from2
        FROM  (
            SELECT 
                T.Id AS Result_Id, 
                True AS _from2
            FROM DataBaseContext.Results AS T) AS T1
            LEFT OUTER JOIN (
            SELECT 
                Key(T.Result_Value_Source).Id AS Result_Id, 
                Key(T.Result_Value_Target).Id AS [Result.Value_Id], 
                True AS _from1
            FROM DataBaseContext.Result_Value AS T) AS T2
            ON T1.Result_Id = T2.Result_Id
            LEFT OUTER JOIN (
            SELECT 
                Key(T.Result_Atribut_Source).Id AS Result_Id, 
                Key(T.Result_Atribut_Target).Id AS [Result.Atribut_Id], 
                True AS _from0
            FROM DataBaseContext.Result_Atribut AS T) AS T3
            ON T1.Result_Id = T3.Result_Id
    ) AS T4");
        }

        /// <summary>
        /// Gets the view for DataBaseContext.Atributs.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView4()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Atributs
        [ПомощникПовара.DBContext.Atribut](T1.Atribut_Id, T1.Atribut_Name)
    FROM (
        SELECT 
            T.Id AS Atribut_Id, 
            T.Name AS Atribut_Name, 
            True AS _from0
        FROM CodeFirstDatabase.Atribut AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for DataBaseContext.AtributValuePairs.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView5()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing AtributValuePairs
        [ПомощникПовара.DBContext.AtributValuePair](T1.AtributValuePair_Id) WITH 
        RELATIONSHIP(CREATEREF(DataBaseContext.Atributs, ROW(T1.[AtributValuePair_Atribut.AtributValuePair_Atribut_Target.Id]),[ПомощникПовара.DBContext.Atribut]),[ПомощникПовара.DBContext.AtributValuePair_Atribut],AtributValuePair_Atribut_Source,AtributValuePair_Atribut_Target) 
        RELATIONSHIP(CREATEREF(DataBaseContext.Values, ROW(T1.[AtributValuePair_Value.AtributValuePair_Value_Target.Id]),[ПомощникПовара.DBContext.Value]),[ПомощникПовара.DBContext.AtributValuePair_Value],AtributValuePair_Value_Source,AtributValuePair_Value_Target) 
        RELATIONSHIP(CREATEREF(DataBaseContext.Results, ROW(T1.[Result_Conditions.Result_Conditions_Source.Id]),[ПомощникПовара.DBContext.Result]),[ПомощникПовара.DBContext.Result_Conditions],Result_Conditions_Target,Result_Conditions_Source) 
    FROM (
        SELECT 
            T.Id AS AtributValuePair_Id, 
            True AS _from0, 
            T.Atribut_Id AS [AtributValuePair_Atribut.AtributValuePair_Atribut_Target.Id], 
            T.Value_Id AS [AtributValuePair_Value.AtributValuePair_Value_Target.Id], 
            T.Result_Id AS [Result_Conditions.Result_Conditions_Source.Id]
        FROM CodeFirstDatabase.AtributValuePair AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for DataBaseContext.AtributValuePair_Atribut.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView6()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing AtributValuePair_Atribut
        [ПомощникПовара.DBContext.AtributValuePair_Atribut](T3.[AtributValuePair_Atribut.AtributValuePair_Atribut_Source], T3.[AtributValuePair_Atribut.AtributValuePair_Atribut_Target])
    FROM (
        SELECT -- Constructing AtributValuePair_Atribut_Source
            CreateRef(DataBaseContext.AtributValuePairs, row(T2.[AtributValuePair_Atribut.AtributValuePair_Atribut_Source.Id]), [ПомощникПовара.DBContext.AtributValuePair]) AS [AtributValuePair_Atribut.AtributValuePair_Atribut_Source], 
            T2.[AtributValuePair_Atribut.AtributValuePair_Atribut_Target]
        FROM (
            SELECT -- Constructing AtributValuePair_Atribut_Target
                T1.[AtributValuePair_Atribut.AtributValuePair_Atribut_Source.Id], 
                CreateRef(DataBaseContext.Atributs, row(T1.[AtributValuePair_Atribut.AtributValuePair_Atribut_Target.Id]), [ПомощникПовара.DBContext.Atribut]) AS [AtributValuePair_Atribut.AtributValuePair_Atribut_Target]
            FROM (
                SELECT 
                    T.Id AS [AtributValuePair_Atribut.AtributValuePair_Atribut_Source.Id], 
                    T.Atribut_Id AS [AtributValuePair_Atribut.AtributValuePair_Atribut_Target.Id], 
                    True AS _from0
                FROM CodeFirstDatabase.AtributValuePair AS T
                WHERE T.Atribut_Id IS NOT NULL
            ) AS T1
        ) AS T2
    ) AS T3");
        }

        /// <summary>
        /// Gets the view for DataBaseContext.AtributValuePair_Value.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView7()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing AtributValuePair_Value
        [ПомощникПовара.DBContext.AtributValuePair_Value](T3.[AtributValuePair_Value.AtributValuePair_Value_Source], T3.[AtributValuePair_Value.AtributValuePair_Value_Target])
    FROM (
        SELECT -- Constructing AtributValuePair_Value_Source
            CreateRef(DataBaseContext.AtributValuePairs, row(T2.[AtributValuePair_Value.AtributValuePair_Value_Source.Id]), [ПомощникПовара.DBContext.AtributValuePair]) AS [AtributValuePair_Value.AtributValuePair_Value_Source], 
            T2.[AtributValuePair_Value.AtributValuePair_Value_Target]
        FROM (
            SELECT -- Constructing AtributValuePair_Value_Target
                T1.[AtributValuePair_Value.AtributValuePair_Value_Source.Id], 
                CreateRef(DataBaseContext.Values, row(T1.[AtributValuePair_Value.AtributValuePair_Value_Target.Id]), [ПомощникПовара.DBContext.Value]) AS [AtributValuePair_Value.AtributValuePair_Value_Target]
            FROM (
                SELECT 
                    T.Id AS [AtributValuePair_Value.AtributValuePair_Value_Source.Id], 
                    T.Value_Id AS [AtributValuePair_Value.AtributValuePair_Value_Target.Id], 
                    True AS _from0
                FROM CodeFirstDatabase.AtributValuePair AS T
                WHERE T.Value_Id IS NOT NULL
            ) AS T1
        ) AS T2
    ) AS T3");
        }

        /// <summary>
        /// Gets the view for DataBaseContext.Result_Conditions.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView8()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Result_Conditions
        [ПомощникПовара.DBContext.Result_Conditions](T3.[Result_Conditions.Result_Conditions_Source], T3.[Result_Conditions.Result_Conditions_Target])
    FROM (
        SELECT -- Constructing Result_Conditions_Source
            CreateRef(DataBaseContext.Results, row(T2.[Result_Conditions.Result_Conditions_Source.Id]), [ПомощникПовара.DBContext.Result]) AS [Result_Conditions.Result_Conditions_Source], 
            T2.[Result_Conditions.Result_Conditions_Target]
        FROM (
            SELECT -- Constructing Result_Conditions_Target
                T1.[Result_Conditions.Result_Conditions_Source.Id], 
                CreateRef(DataBaseContext.AtributValuePairs, row(T1.[Result_Conditions.Result_Conditions_Target.Id]), [ПомощникПовара.DBContext.AtributValuePair]) AS [Result_Conditions.Result_Conditions_Target]
            FROM (
                SELECT 
                    T.Result_Id AS [Result_Conditions.Result_Conditions_Source.Id], 
                    T.Id AS [Result_Conditions.Result_Conditions_Target.Id], 
                    True AS _from0
                FROM CodeFirstDatabase.AtributValuePair AS T
                WHERE T.Result_Id IS NOT NULL
            ) AS T1
        ) AS T2
    ) AS T3");
        }

        /// <summary>
        /// Gets the view for DataBaseContext.Values.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView9()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Values
        [ПомощникПовара.DBContext.Value](T1.Value_Id, T1.Value_Name)
    FROM (
        SELECT 
            T.Id AS Value_Id, 
            T.Name AS Value_Name, 
            True AS _from0
        FROM CodeFirstDatabase.[Value] AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for DataBaseContext.Results.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView10()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Results
        [ПомощникПовара.DBContext.Result](T1.Result_Id) WITH 
        RELATIONSHIP(CREATEREF(DataBaseContext.Atributs, ROW(T1.[Result_Atribut.Result_Atribut_Target.Id]),[ПомощникПовара.DBContext.Atribut]),[ПомощникПовара.DBContext.Result_Atribut],Result_Atribut_Source,Result_Atribut_Target) 
        RELATIONSHIP(CREATEREF(DataBaseContext.Values, ROW(T1.[Result_Value.Result_Value_Target.Id]),[ПомощникПовара.DBContext.Value]),[ПомощникПовара.DBContext.Result_Value],Result_Value_Source,Result_Value_Target) 
    FROM (
        SELECT 
            T.Id AS Result_Id, 
            True AS _from0, 
            T.Atribut_Id AS [Result_Atribut.Result_Atribut_Target.Id], 
            T.Value_Id AS [Result_Value.Result_Value_Target.Id]
        FROM CodeFirstDatabase.Result AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for DataBaseContext.Result_Atribut.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView11()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Result_Atribut
        [ПомощникПовара.DBContext.Result_Atribut](T3.[Result_Atribut.Result_Atribut_Source], T3.[Result_Atribut.Result_Atribut_Target])
    FROM (
        SELECT -- Constructing Result_Atribut_Source
            CreateRef(DataBaseContext.Results, row(T2.[Result_Atribut.Result_Atribut_Source.Id]), [ПомощникПовара.DBContext.Result]) AS [Result_Atribut.Result_Atribut_Source], 
            T2.[Result_Atribut.Result_Atribut_Target]
        FROM (
            SELECT -- Constructing Result_Atribut_Target
                T1.[Result_Atribut.Result_Atribut_Source.Id], 
                CreateRef(DataBaseContext.Atributs, row(T1.[Result_Atribut.Result_Atribut_Target.Id]), [ПомощникПовара.DBContext.Atribut]) AS [Result_Atribut.Result_Atribut_Target]
            FROM (
                SELECT 
                    T.Id AS [Result_Atribut.Result_Atribut_Source.Id], 
                    T.Atribut_Id AS [Result_Atribut.Result_Atribut_Target.Id], 
                    True AS _from0
                FROM CodeFirstDatabase.Result AS T
                WHERE T.Atribut_Id IS NOT NULL
            ) AS T1
        ) AS T2
    ) AS T3");
        }

        /// <summary>
        /// Gets the view for DataBaseContext.Result_Value.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView12()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Result_Value
        [ПомощникПовара.DBContext.Result_Value](T3.[Result_Value.Result_Value_Source], T3.[Result_Value.Result_Value_Target])
    FROM (
        SELECT -- Constructing Result_Value_Source
            CreateRef(DataBaseContext.Results, row(T2.[Result_Value.Result_Value_Source.Id]), [ПомощникПовара.DBContext.Result]) AS [Result_Value.Result_Value_Source], 
            T2.[Result_Value.Result_Value_Target]
        FROM (
            SELECT -- Constructing Result_Value_Target
                T1.[Result_Value.Result_Value_Source.Id], 
                CreateRef(DataBaseContext.Values, row(T1.[Result_Value.Result_Value_Target.Id]), [ПомощникПовара.DBContext.Value]) AS [Result_Value.Result_Value_Target]
            FROM (
                SELECT 
                    T.Id AS [Result_Value.Result_Value_Source.Id], 
                    T.Value_Id AS [Result_Value.Result_Value_Target.Id], 
                    True AS _from0
                FROM CodeFirstDatabase.Result AS T
                WHERE T.Value_Id IS NOT NULL
            ) AS T1
        ) AS T2
    ) AS T3");
        }
    }
}
