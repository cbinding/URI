/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: URI
Classes	: CRM42
License : http://creativecommons.org/licenses/by/3.0/ 
================================================================================
History :

06/05/2011  CFB Created class(es)
================================================================================
*/
using System;

namespace URI
{    
    /// <summary>
    /// Defines RDF namespace, entity and property URI constants for CIDOC CRM v4.2
    /// </summary>
    /// <example>This sample code shows how use the constants defined in the class
    /// <code>
    /// // C# example:
    /// String s = URI.CRM42.E10; 
    /// // = http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E10.Transfer_of_Custody
    /// </code>
    ///</example>
    public static class CRM42
    {        
        #region namespace
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#</summary>
        public const String NS = "http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#";
        //public const String NS_PREFIX = "crm42";
        #endregion     
        
        #region entities
        /// <summmary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E1.CRM_Entity</summmary>
        public const String E1 = NS + "E1.CRM_Entity";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E2.Temporal_Entity</summary>
        public const String E2 = NS + "E2.Temporal_Entity";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E3.Condition_State</summary>
        public const String E3 = NS + "E3.Condition_State";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E4.Period</summary>
        public const String E4 = NS + "E4.Period";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E5.Event</summary>
        public const String E5 = NS + "E5.Event";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E6.Destruction</summary>
        public const String E6 = NS + "E6.Destruction";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E7.Activity</summary>
        public const String E7 = NS + "E7.Activity";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E8.Acquisition</summary>
        public const String E8 = NS + "E8.Acquisition";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E9.Move</summary>
        public const String E9 = NS + "E9.Move";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E10.Transfer_of_Custody</summary>
        public const String E10 = NS + "E10.Transfer_of_Custody";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E11.Modification</summary>
        public const String E11 = NS + "E11.Modification";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E12.Production</summary>
        public const String E12 = NS + "E12.Production";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E13.Attribute_Assignment</summary>
        public const String E13 = NS + "E13.Attribute_Assignment";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E14.Condition_Assessment</summary>
        public const String E14 = NS + "E14.Condition_Assessment";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E15.Identifier_Assignment</summary>
        public const String E15 = NS + "E15.Identifier_Assignment";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E16.Measurement</summary>
        public const String E16 = NS + "E16.Measurement";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E17.Type_Assignment</summary>
        public const String E17 = NS + "E17.Type_Assignment";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E18.Physical_Thing</summary>
        public const String E18 = NS + "E18.Physical_Thing";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E19.Physical_Object</summary>
        public const String E19 = NS + "E19.Physical_Object";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E20.Biological_Object</summary>
        public const String E20 = NS + "E20.Biological_Object";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E21.Person</summary>
        public const String E21 = NS + "E21.Person";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E22.Man-Made_Object</summary>
        public const String E22 = NS + "E22.Man-Made_Object";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E24.Physical_Man-Made_Thing</summary>
        public const String E24 = NS + "E24.Physical_Man-Made_Thing";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E25.Man-Made_Feature</summary>
        public const String E25 = NS + "E25.Man-Made_Feature";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E26.Physical_Feature</summary>
        public const String E26 = NS + "E26.Physical_Feature";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E27.Site</summary>
        public const String E27 = NS + "E27.Site";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E28.Conceptual_Object</summary>
        public const String E28 = NS + "E28.Conceptual_Object";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E29.Design_or_Procedure</summary>
        public const String E29 = NS + "E29.Design_or_Procedure";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E30.Right</summary>
        public const String E30 = NS + "E30.Right";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E31.Document</summary>
        public const String E31 = NS + "E31.Document";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E32.Authority_Document</summary>
        public const String E32 = NS + "E32.Authority_Document";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E33.Linguistic_Object</summary>
        public const String E33 = NS + "E33.Linguistic_Object";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E34.Inscription</summary>
        public const String E34 = NS + "E34.Inscription";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E35.Title</summary>
        public const String E35 = NS + "E35.Title";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E36.Visual_Item</summary>
        public const String E36 = NS + "E36.Visual_Item";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E37.Mark</summary>
        public const String E37 = NS + "E37.Mark";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E38.Image</summary>
        public const String E38 = NS + "E38.Image";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E39.Actor</summary>
        public const String E39 = NS + "E39.Actor";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E40.Legal_Body</summary>
        public const String E40 = NS + "E40.Legal_Body";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E41.Appellation</summary>
        public const String E41 = NS + "E41.Appellation";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E42.Object_Identifier</summary>
        public const String E42 = NS + "E42.Object_Identifier";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E44.Place_Appellation</summary>
        public const String E44 = NS + "E44.Place_Appellation";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E45.Address</summary>
        public const String E45 = NS + "E45.Address";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E46.Section_Definition</summary>
        public const String E46 = NS + "E46.Section_Definition";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E47.Spatial_Coordinates</summary>
        public const String E47 = NS + "E47.Spatial_Coordinates";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E48.Place_Name</summary>
        public const String E48 = NS + "E48.Place_Name";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E49.Time_Appellation</summary>
        public const String E49 = NS + "E49.Time_Appellation";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E50.Date</summary>
        public const String E50 = NS + "E50.Date";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E51.Contact_Point</summary>
        public const String E51 = NS + "E51.Contact_Point";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E52.Time-Span</summary>
        public const String E52 = NS + "E52.Time-Span";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E53.Place</summary>
        public const String E53 = NS + "E53.Place";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E54.Dimension</summary>
        public const String E54 = NS + "E54.Dimension";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E55.Type</summary>
        public const String E55 = NS + "E55.Type";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E56.Language</summary>
        public const String E56 = NS + "E56.Language";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E57.Material</summary>
        public const String E57 = NS + "E57.Material";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E58.Measurement_Unit</summary>
        public const String E58 = NS + "E58.Measurement_Unit";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E59.Primitive_Value</summary>
        public const String E59 = NS + "E59.Primitive_Value";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E60.Number</summary>
        public const String E60 = NS + "E60.Number";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E61.Time_Primitive</summary>
        public const String E61 = NS + "E61.Time_Primitive";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E62.String</summary>
        public const String E62 = NS + "E62.String";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E63.Beginning_of_Existence</summary>
        public const String E63 = NS + "E63.Beginning_of_Existence";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E64.End_of_Existence</summary>
        public const String E64 = NS + "E64.End_of_Existence";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E65.Creation</summary>
        public const String E65 = NS + "E65.Creation";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E66.Formation</summary>
        public const String E66 = NS + "E66.Formation";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E67.Birth</summary>
        public const String E67 = NS + "E67.Birth";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E68.Dissolution</summary>
        public const String E68 = NS + "E68.Dissolution";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E69.Death</summary>
        public const String E69 = NS + "E69.Death";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E70.Thing</summary>
        public const String E70 = NS + "E70.Thing";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E71.Man-Made_Thing</summary>
        public const String E71 = NS + "E71.Man-Made_Thing";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E72.Legal_Object</summary>
        public const String E72 = NS + "E72.Legal_Object";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E73.Information_Object</summary>
        public const String E73 = NS + "E73.Information_Object";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E74.Group</summary>
        public const String E74 = NS + "E74.Group";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E75.Conceptual_Object_Appellation</summary>
        public const String E75 = NS + "E75.Conceptual_Object_Appellation";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E77.Persistent_Item</summary>
        public const String E77 = NS + "E77.Persistent_Item";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E78.Collection</summary>
        public const String E78 = NS + "E78.Collection";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E79.Part_Addition</summary>
        public const String E79 = NS + "E79.Part_Addition";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E80.Part_Removal</summary>
        public const String E80 = NS + "E80.Part_Removal";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E81.Transformation</summary>
        public const String E81 = NS + "E81.Transformation";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E82.Actor_Appellation</summary>
        public const String E82 = NS + "E82.Actor_Appellation";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E83.Type_Creation</summary>
        public const String E83 = NS + "E83.Type_Creation";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#E84.Information_Carrier</summary>
        public const String E84 = NS + "E84.Information_Carrier";
        #endregion

        #region properties
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P1F.is_identified_by</summary>
        public const String P1F = NS + "P1F.is_identified_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P1B.identifies</summary>
        public const String P1B = NS + "P1B.identifies";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P2F.has_type</summary>
        public const String P2F = NS + "P2F.has_type";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P2B.is_type_of</summary>
        public const String P2B = NS + "P2B.is_type_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P3F.has_note</summary>
        public const String P3F = NS + "P3F.has_note";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P4F.has_time-span</summary>
        public const String P4F = NS + "P4F.has_time-span";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P4B.is_time-span_of</summary>
        public const String P4B = NS + "P4B.is_time-span_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P5F.consists_of</summary>
        public const String P5F = NS + "P5F.consists_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P5B.forms_part_of</summary>
        public const String P5B = NS + "P5B.forms_part_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P7F.took_place_at</summary>
        public const String P7F = NS + "P7F.took_place_at";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P7B.witnessed</summary>
        public const String P7B = NS + "P7B.witnessed";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P8F.took_place_on_or_within</summary>
        public const String P8F = NS + "P8F.took_place_on_or_within";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P8B.witnessed</summary>
        public const String P8B = NS + "P8B.witnessed";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P9F.consists_of</summary>
        public const String P9F = NS + "P9F.consists_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P9B.forms_part_of</summary>
        public const String P9B = NS + "P9B.forms_part_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P10F.falls_within</summary>
        public const String P10F = NS + "P10F.falls_within";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P10B.contains</summary>
        public const String P10B = NS + "P10B.contains";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P11F.had_participant</summary>
        public const String P11F = NS + "P11F.had_participant";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P11B.participated_in</summary>
        public const String P11B = NS + "P11B.participated_in";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P12F.occurred_in_the_presence_of</summary>
        public const String P12F = NS + "P12F.occurred_in_the_presence_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P12B.was_present_at</summary>
        public const String P12B = NS + "P12B.was_present_at";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P13F.destroyed</summary>
        public const String P13F = NS + "P13F.destroyed";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P13B.was_destroyed_by</summary>
        public const String P13B = NS + "P13B.was_destroyed_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P14F.carried_out_by</summary>
        public const String P14F = NS + "P14F.carried_out_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P14B.performed</summary>
        public const String P14B = NS + "P14B.performed";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P15F.was_influenced_by</summary>
        public const String P15F = NS + "P15F.was_influenced_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P15B.influenced</summary>
        public const String P15B = NS + "P15B.influenced";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P16F.used_specific_object</summary>
        public const String P16F = NS + "P16F.used_specific_object";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P16B.was_used_for</summary>
        public const String P16B = NS + "P16B.was_used_for";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P17F.was_motivated_by</summary>
        public const String P17F = NS + "P17F.was_motivated_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P17B.motivated</summary>
        public const String P17B = NS + "P17B.motivated";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P19F.was_intended_use_of</summary>
        public const String P19F = NS + "P19F.was_intended_use_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P19B.was_made_for</summary>
        public const String P19B = NS + "P19B.was_made_for";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P20F.had_specific_purpose</summary>
        public const String P20F = NS + "P20F.had_specific_purpose";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P20B.was_purpose_of</summary>
        public const String P20B = NS + "P20B.was_purpose_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P21F.had_general_purpose</summary>
        public const String P21F = NS + "P21F.had_general_purpose";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P21B.was_purpose_of</summary>
        public const String P21B = NS + "P21B.was_purpose_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P22F.transferred_title_to</summary>
        public const String P22F = NS + "P22F.transferred_title_to";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P22B.acquired_title_through</summary>
        public const String P22B = NS + "P22B.acquired_title_through";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P23F.transferred_title_from</summary>
        public const String P23F = NS + "P23F.transferred_title_from";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P23B.surrendered_title_through</summary>
        public const String P23B = NS + "P23B.surrendered_title_through";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P24F.transferred_title_of</summary>
        public const String P24F = NS + "P24F.transferred_title_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P24B.changed_ownership_through</summary>
        public const String P24B = NS + "P24B.changed_ownership_through";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P25F.moved</summary>
        public const String P25F = NS + "P25F.moved";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P25B.moved_by</summary>
        public const String P25B = NS + "P25B.moved_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P26F.moved_to</summary>
        public const String P26F = NS + "P26F.moved_to";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P26B.was_destination_of</summary>
        public const String P26B = NS + "P26B.was_destination_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P27F.moved_from</summary>
        public const String P27F = NS + "P27F.moved_from";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P27B.was_origin_of</summary>
        public const String P27B = NS + "P27B.was_origin_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P28F.custody_surrendered_by</summary>
        public const String P28F = NS + "P28F.custody_surrendered_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P28B.surrendered_custody_through</summary>
        public const String P28B = NS + "P28B.surrendered_custody_through";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P29F.custody_received_by</summary>
        public const String P29F = NS + "P29F.custody_received_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P29B.received_custody_through</summary>
        public const String P29B = NS + "P29B.received_custody_through";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P30F.transferred_custody_of</summary>
        public const String P30F = NS + "P30F.transferred_custody_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P30B.custody_transferred_through</summary>
        public const String P30B = NS + "P30B.custody_transferred_through";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P31F.has_modified</summary>
        public const String P31F = NS + "P31F.has_modified";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P31B.was_modified_by</summary>
        public const String P31B = NS + "P31B.was_modified_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P32F.used_general_technique</summary>
        public const String P32F = NS + "P32F.used_general_technique";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P32B.was_technique_of</summary>
        public const String P32B = NS + "P32B.was_technique_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P33F.used_specific_technique</summary>
        public const String P33F = NS + "P33F.used_specific_technique";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P33B.was_used_by</summary>
        public const String P33B = NS + "P33B.was_used_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P34F.concerned</summary>
        public const String P34F = NS + "P34F.concerned";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P34B.was_assessed_by</summary>
        public const String P34B = NS + "P34B.was_assessed_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P35F.has_identified</summary>
        public const String P35F = NS + "P35F.has_identified";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P35B.identified_by</summary>
        public const String P35B = NS + "P35B.identified_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P36F.registered</summary>
        public const String P36F = NS + "P36F.registered";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P36B.was_registered_by</summary>
        public const String P36B = NS + "P36B.was_registered_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P37F.assigned</summary>
        public const String P37F = NS + "P37F.assigned";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P37B.was_assigned_by</summary>
        public const String P37B = NS + "P37B.was_assigned_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P38F.deassigned</summary>
        public const String P38F = NS + "P38F.deassigned";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P38B.was_deassigned_by</summary>
        public const String P38B = NS + "P38B.was_deassigned_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P39F.measured</summary>
        public const String P39F = NS + "P39F.measured";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P39B.was_measured_by</summary>
        public const String P39B = NS + "P39B.was_measured_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P40F.observed_dimension</summary>
        public const String P40F = NS + "P40F.observed_dimension";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P40B.was_observed_in</summary>
        public const String P40B = NS + "P40B.was_observed_in";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P41F.classified</summary>
        public const String P41F = NS + "P41F.classified";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P41B.was_classified_by</summary>
        public const String P41B = NS + "P41B.was_classified_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P42F.assigned</summary>
        public const String P42F = NS + "P42F.assigned";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P42B.was_assigned_by</summary>
        public const String P42B = NS + "P42B.was_assigned_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P43F.has_dimension</summary>
        public const String P43F = NS + "P43F.has_dimension";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P43B.is_dimension_of</summary>
        public const String P43B = NS + "P43B.is_dimension_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P44F.has_condition</summary>
        public const String P44F = NS + "P44F.has_condition";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P44B.is_condition_of</summary>
        public const String P44B = NS + "P44B.is_condition_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P45F.consists_of</summary>
        public const String P45F = NS + "P45F.consists_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P45B.is_incorporated_in</summary>
        public const String P45B = NS + "P45B.is_incorporated_in";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P46F.is_composed_of</summary>
        public const String P46F = NS + "P46F.is_composed_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P46B.forms_part_of</summary>
        public const String P46B = NS + "P46B.forms_part_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P47F.is_identified_by</summary>
        public const String P47F = NS + "P47F.is_identified_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P47B.identifies</summary>
        public const String P47B = NS + "P47B.identifies";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P48F.has_preferred_identifier</summary>
        public const String P48F = NS + "P48F.has_preferred_identifier";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P48B.is_preferred_identifier_of</summary>
        public const String P48B = NS + "P48B.is_preferred_identifier_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P49F.has_former_or_current_keeper</summary>
        public const String P49F = NS + "P49F.has_former_or_current_keeper";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P49B.is_former_or_current_keeper_of</summary>
        public const String P49B = NS + "P49B.is_former_or_current_keeper_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P50F.has_current_keeper</summary>
        public const String P50F = NS + "P50F.has_current_keeper";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P50B.is_current_keeper_of</summary>
        public const String P50B = NS + "P50B.is_current_keeper_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P51F.has_former_or_current_owner</summary>
        public const String P51F = NS + "P51F.has_former_or_current_owner";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P51B.is_former_or_current_owner_of</summary>
        public const String P51B = NS + "P51B.is_former_or_current_owner_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P52F.has_current_owner</summary>
        public const String P52F = NS + "P52F.has_current_owner";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P52B.is_current_owner_of</summary>
        public const String P52B = NS + "P52B.is_current_owner_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P53F.has_former_or_current_location</summary>
        public const String P53F = NS + "P53F.has_former_or_current_location";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P53B.is_former_or_current_location_of</summary>
        public const String P53B = NS + "P53B.is_former_or_current_location_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P54F.has_current_permanent_location</summary>
        public const String P54F = NS + "P54F.has_current_permanent_location";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P54B.is_current_permanent_location_of</summary>
        public const String P54B = NS + "P54B.is_current_permanent_location_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P55F.has_current_location</summary>
        public const String P55F = NS + "P55F.has_current_location";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P55B.currently_holds</summary>
        public const String P55B = NS + "P55B.currently_holds";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P56F.bears_feature</summary>
        public const String P56F = NS + "P56F.bears_feature";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P56B.is_found_on</summary>
        public const String P56B = NS + "P56B.is_found_on";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P57F.has_number_of_parts</summary>
        public const String P57F = NS + "P57F.has_number_of_parts";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P58F.has_section_definition</summary>
        public const String P58F = NS + "P58F.has_section_definition";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P58B.defines_section</summary>
        public const String P58B = NS + "P58B.defines_section";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P59F.has_section</summary>
        public const String P59F = NS + "P59F.has_section";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P59B.is_located_on_or_within</summary>
        public const String P59B = NS + "P59B.is_located_on_or_within";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P62F.depicts</summary>
        public const String P62F = NS + "P62F.depicts";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P62B.is_depicted_by</summary>
        public const String P62B = NS + "P62B.is_depicted_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P65F.shows_visual_item</summary>
        public const String P65F = NS + "P65F.shows_visual_item";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P65B.is_shown_by</summary>
        public const String P65B = NS + "P65B.is_shown_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P67F.refers_to</summary>
        public const String P67F = NS + "P67F.refers_to";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P67B.is_referred_to_by</summary>
        public const String P67B = NS + "P67B.is_referred_to_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P68F.usually_employs</summary>
        public const String P68F = NS + "P68F.usually_employs";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P68B.is_usually_employed_by</summary>
        public const String P68B = NS + "P68B.is_usually_employed_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P69F.is_associated_with</summary>
        public const String P69F = NS + "P69F.is_associated_with";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P70F.documents</summary>
        public const String P70F = NS + "P70F.documents";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P70B.is_documented_in</summary>
        public const String P70B = NS + "P70B.is_documented_in";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P71F.lists</summary>
        public const String P71F = NS + "P71F.lists";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P71B.is_listed_in</summary>
        public const String P71B = NS + "P71B.is_listed_in";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P72F.has_language</summary>
        public const String P72F = NS + "P72F.has_language";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P72B.is_language_of</summary>
        public const String P72B = NS + "P72B.is_language_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P73F.has_translation</summary>
        public const String P73F = NS + "P73F.has_translation";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P73B.is_translation_of</summary>
        public const String P73B = NS + "P73B.is_translation_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P74F.has_current_or_former_residence</summary>
        public const String P74F = NS + "P74F.has_current_or_former_residence";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P74B.is_current_or_former_residence_of</summary>
        public const String P74B = NS + "P74B.is_current_or_former_residence_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P75F.possesses</summary>
        public const String P75F = NS + "P75F.possesses";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P75B.is_possessed_by</summary>
        public const String P75B = NS + "P75B.is_possessed_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P76F.has_contact_point</summary>
        public const String P76F = NS + "P76F.has_contact_point";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P76B.provides_access_to</summary>
        public const String P76B = NS + "P76B.provides_access_to";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P78F.is_identified_by</summary>
        public const String P78F = NS + "P78F.is_identified_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P78B.identifies</summary>
        public const String P78B = NS + "P78B.identifies";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P79F.beginning_is_qualified_by</summary>
        public const String P79F = NS + "P79F.beginning_is_qualified_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P80F.end_is_qualified_by</summary>
        public const String P80F = NS + "P80F.end_is_qualified_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P81F.ongoing_throughout</summary>
        public const String P81F = NS + "P81F.ongoing_throughout";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P82F.at_some_time_within</summary>
        public const String P82F = NS + "P82F.at_some_time_within";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P83F.had_at_least_duration</summary>
        public const String P83F = NS + "P83F.had_at_least_duration";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P83B.was_minimum_duration_of</summary>
        public const String P83B = NS + "P83B.was_minimum_duration_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P84F.had_at_most_duration</summary>
        public const String P84F = NS + "P84F.had_at_most_duration";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P84B.was_maximum_duration_of</summary>
        public const String P84B = NS + "P84B.was_maximum_duration_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P86F.falls_within</summary>
        public const String P86F = NS + "P86F.falls_within";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P86B.contains</summary>
        public const String P86B = NS + "P86B.contains";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P87F.is_identified_by</summary>
        public const String P87F = NS + "P87F.is_identified_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P87B.identifies</summary>
        public const String P87B = NS + "P87B.identifies";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P88F.consists_of</summary>
        public const String P88F = NS + "P88F.consists_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P88B.forms_part_of</summary>
        public const String P88B = NS + "P88B.forms_part_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P89F.falls_within</summary>
        public const String P89F = NS + "P89F.falls_within";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P89B.contains</summary>
        public const String P89B = NS + "P89B.contains";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P90F.has_value</summary>
        public const String P90F = NS + "P90F.has_value";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P91F.has_unit</summary>
        public const String P91F = NS + "P91F.has_unit";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P91B.is_unit_of</summary>
        public const String P91B = NS + "P91B.is_unit_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P92F.brought_into_existence</summary>
        public const String P92F = NS + "P92F.brought_into_existence";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P92B.was_brought_into_existence_by</summary>
        public const String P92B = NS + "P92B.was_brought_into_existence_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P93F.took_out_of_existence</summary>
        public const String P93F = NS + "P93F.took_out_of_existence";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P93B.was_taken_out_of_existence_by</summary>
        public const String P93B = NS + "P93B.was_taken_out_of_existence_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P94F.has_created</summary>
        public const String P94F = NS + "P94F.has_created";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P94B.was_created_by</summary>
        public const String P94B = NS + "P94B.was_created_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P95F.has_formed</summary>
        public const String P95F = NS + "P95F.has_formed";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P95B.was_formed_by</summary>
        public const String P95B = NS + "P95B.was_formed_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P96F.by_mother</summary>
        public const String P96F = NS + "P96F.by_mother";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P96B.gave_birth</summary>
        public const String P96B = NS + "P96B.gave_birth";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P97F.from_father</summary>
        public const String P97F = NS + "P97F.from_father";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P97B.was_father_for</summary>
        public const String P97B = NS + "P97B.was_father_for";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P98F.brought_into_life</summary>
        public const String P98F = NS + "P98F.brought_into_life";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P98B.was_born</summary>
        public const String P98B = NS + "P98B.was_born";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P99F.dissolved</summary>
        public const String P99F = NS + "P99F.dissolved";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P99B.was_dissolved_by</summary>
        public const String P99B = NS + "P99B.was_dissolved_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P100F.was_death_of</summary>
        public const String P100F = NS + "P100F.was_death_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P100B.died_in</summary>
        public const String P100B = NS + "P100B.died_in";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P101F.had_as_general_use</summary>
        public const String P101F = NS + "P101F.had_as_general_use";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P101B.was_use_of</summary>
        public const String P101B = NS + "P101B.was_use_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P102F.has_title</summary>
        public const String P102F = NS + "P102F.has_title";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P102B.is_title_of</summary>
        public const String P102B = NS + "P102B.is_title_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P103F.was_intended_for</summary>
        public const String P103F = NS + "P103F.was_intended_for";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P103B.was_intention_of</summary>
        public const String P103B = NS + "P103B.was_intention_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P104F.is_subject_to</summary>
        public const String P104F = NS + "P104F.is_subject_to";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P104B.applies_to</summary>
        public const String P104B = NS + "P104B.applies_to";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P105F.right_held_by</summary>
        public const String P105F = NS + "P105F.right_held_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P105B.has_right_on</summary>
        public const String P105B = NS + "P105B.has_right_on";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P106F.is_composed_of</summary>
        public const String P106F = NS + "P106F.is_composed_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P106B.forms_part_of</summary>
        public const String P106B = NS + "P106B.forms_part_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P107F.has_current_or_former_member</summary>
        public const String P107F = NS + "P107F.has_current_or_former_member";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P107B.is_current_or_former_member_of</summary>
        public const String P107B = NS + "P107B.is_current_or_former_member_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P108F.has_produced</summary>
        public const String P108F = NS + "P108F.has_produced";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P108B.was_produced_by</summary>
        public const String P108B = NS + "P108B.was_produced_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P109F.has_current_or_former_curator</summary>
        public const String P109F = NS + "P109F.has_current_or_former_curator";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P109B.is_current_or_former_curator_of</summary>
        public const String P109B = NS + "P109B.is_current_or_former_curator_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P110F.augmented</summary>
        public const String P110F = NS + "P110F.augmented";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P110B.was_augmented_by</summary>
        public const String P110B = NS + "P110B.was_augmented_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P111F.added</summary>
        public const String P111F = NS + "P111F.added";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P111B.was_added_by</summary>
        public const String P111B = NS + "P111B.was_added_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P112F.diminished</summary>
        public const String P112F = NS + "P112F.diminished";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P112B.was_diminished_by</summary>
        public const String P112B = NS + "P112B.was_diminished_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P113F.removed</summary>
        public const String P113F = NS + "P113F.removed";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P113B.was_removed_by</summary>
        public const String P113B = NS + "P113B.was_removed_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P114F.is_equal_in_time_to</summary>
        public const String P114F = NS + "P114F.is_equal_in_time_to";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P115F.finishes</summary>
        public const String P115F = NS + "P115F.finishes";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P115B.is_finished_by</summary>
        public const String P115B = NS + "P115B.is_finished_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P116F.starts</summary>
        public const String P116F = NS + "P116F.starts";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P116B.is_started_by</summary>
        public const String P116B = NS + "P116B.is_started_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P117F.occurs_during</summary>
        public const String P117F = NS + "P117F.occurs_during";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P117B.includes</summary>
        public const String P117B = NS + "P117B.includes";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P118F.overlaps_in_time_with</summary>
        public const String P118F = NS + "P118F.overlaps_in_time_with";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P118B.is_overlapped_in_time_by</summary>
        public const String P118B = NS + "P118B.is_overlapped_in_time_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P119F.meets_in_time_with</summary>
        public const String P119F = NS + "P119F.meets_in_time_with";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P119B.is_met_in_time_by</summary>
        public const String P119B = NS + "P119B.is_met_in_time_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P120F.occurs_before</summary>
        public const String P120F = NS + "P120F.occurs_before";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P120B.occurs_after</summary>
        public const String P120B = NS + "P120B.occurs_after";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P121F.overlaps_with</summary>
        public const String P121F = NS + "P121F.overlaps_with";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P122F.borders_with</summary>
        public const String P122F = NS + "P122F.borders_with";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P123F.resulted_in</summary>
        public const String P123F = NS + "P123F.resulted_in";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P123B.resulted_from</summary>
        public const String P123B = NS + "P123B.resulted_from";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P124F.transformed</summary>
        public const String P124F = NS + "P124F.transformed";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P124B.was_transformed_by</summary>
        public const String P124B = NS + "P124B.was_transformed_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P125F.used_object_of_type</summary>
        public const String P125F = NS + "P125F.used_object_of_type";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P125B.was_type_of_object_used_in</summary>
        public const String P125B = NS + "P125B.was_type_of_object_used_in";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P126F.employed</summary>
        public const String P126F = NS + "P126F.employed";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P126B.was_employed_in</summary>
        public const String P126B = NS + "P126B.was_employed_in";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P127F.has_broader_term</summary>
        public const String P127F = NS + "P127F.has_broader_term";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P127B.has_narrower_term</summary>
        public const String P127B = NS + "P127B.has_narrower_term";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P128F.carries</summary>
        public const String P128F = NS + "P128F.carries";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P128B.is_carried_by</summary>
        public const String P128B = NS + "P128B.is_carried_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P129F.is_about</summary>
        public const String P129F = NS + "P129F.is_about";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P129B.is_subject_of</summary>
        public const String P129B = NS + "P129B.is_subject_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P130F.shows_features_of</summary>
        public const String P130F = NS + "P130F.shows_features_of";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P130B.features_are_also_found_on</summary>
        public const String P130B = NS + "P130B.features_are_also_found_on";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P131F.is_identified_by</summary>
        public const String P131F = NS + "P131F.is_identified_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P131B.identifies</summary>
        public const String P131B = NS + "P131B.identifies";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P132F.overlaps_with</summary>
        public const String P132F = NS + "P132F.overlaps_with";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P133F.is_separated_from</summary>
        public const String P133F = NS + "P133F.is_separated_from";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P134F.continued</summary>
        public const String P134F = NS + "P134F.continued";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P134B.was_continued_by</summary>
        public const String P134B = NS + "P134B.was_continued_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P135F.created_type</summary>
        public const String P135F = NS + "P135F.created_type";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P135B.was_created_by</summary>
        public const String P135B = NS + "P135B.was_created_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P136F.was_based_on</summary>
        public const String P136F = NS + "P136F.was_based_on";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P136B.supported_type_creation</summary>
        public const String P136B = NS + "P136B.supported_type_creation";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P137F.is_exemplified_by</summary>
        public const String P137F = NS + "P137F.is_exemplified_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P137B.exemplifies</summary>
        public const String P137B = NS + "P137B.exemplifies";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P138F.represents</summary>
        public const String P138F = NS + "P138F.represents";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P138B.has_representation</summary>
        public const String P138B = NS + "P138B.has_representation";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P139F.has_alternative_form</summary>
        public const String P139F = NS + "P139F.has_alternative_form";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P140F.assigned_attribute_to</summary>
        public const String P140F = NS + "P140F.assigned_attribute_to";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P140B.was_attributed_by</summary>
        public const String P140B = NS + "P140B.was_attributed_by";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P141F.assigned</summary>
        public const String P141F = NS + "P141F.assigned";
        /// <summary>http://cidoc.ics.forth.gr/rdfs/cidoc_v4.2.rdfs#P141B.was_assigned_by</summary>
        public const String P141B = NS + "P141B.was_assigned_by";
        #endregion
        
    }  
}
