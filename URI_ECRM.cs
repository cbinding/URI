/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: URI
Classes	: ECRM
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
    /// Defines RDF namespace, entity and property URI constants for Erlangen 
    /// implementation of CIDOC CRM model
    /// </summary>
    /// <example> This sample code shows how use the constants defined in the class
    /// <code>
    /// // C# example:
    /// String s = URI.ECRM.E9;
    /// // = http://erlangen-crm.org/110404/E9_Move
    /// </code>
    ///</example>
    public static class ECRM
    {
        #region namespace
        /// <summary>http://erlangen-crm.org/110404/</summary>
        public const String NS = "http://erlangen-crm.org/110404/";
        //public const String NS_PREFIX = "ecrm";
        #endregion

        #region entities
        /// <summary>http://erlangen-crm.org/110404/E1_CRM_Entity</summary>
        public const String E1 = NS + "E1_CRM_Entity";
        /// <summary>http://erlangen-crm.org/110404/E2_Temporal_Entity</summary>
        public const String E2 = NS + "E2_Temporal_Entity";
        /// <summary>http://erlangen-crm.org/110404/E3_Condition_State</summary>
        public const String E3 = NS + "E3_Condition_State";
        /// <summary>http://erlangen-crm.org/110404/E4_Period</summary>
        public const String E4 = NS + "E4_Period";
        /// <summary>http://erlangen-crm.org/110404/E5_Event</summary>
        public const String E5 = NS + "E5_Event";
        /// <summary>http://erlangen-crm.org/110404/E6_Destruction</summary>
        public const String E6 = NS + "E6_Destruction";
        /// <summary>http://erlangen-crm.org/110404/E7_Activity</summary>
        public const String E7 = NS + "E7_Activity";
        /// <summary>http://erlangen-crm.org/110404/E8_Acquisition</summary>
        public const String E8 = NS + "E8_Acquisition";
        /// <summary>http://erlangen-crm.org/110404/E9_Move</summary>
        public const String E9 = NS + "E9_Move";
        /// <summary>http://erlangen-crm.org/110404/E10_Transfer_of_Custody</summary>
        public const String E10 = NS + "E10_Transfer_of_Custody";
        /// <summary>http://erlangen-crm.org/110404/E11_Modification</summary>
        public const String E11 = NS + "E11_Modification";
        /// <summary>http://erlangen-crm.org/110404/E12_Production</summary>
        public const String E12 = NS + "E12_Production";
        /// <summary>http://erlangen-crm.org/110404/E13_Attribute_Assignment</summary>
        public const String E13 = NS + "E13_Attribute_Assignment";
        /// <summary>http://erlangen-crm.org/110404/E14_Condition_Assessment</summary>
        public const String E14 = NS + "E14_Condition_Assessment";
        /// <summary>http://erlangen-crm.org/110404/E15_Identifier_Assignment</summary>
        public const String E15 = NS + "E15_Identifier_Assignment";
        /// <summary>http://erlangen-crm.org/110404/E16_Measurement</summary>
        public const String E16 = NS + "E16_Measurement";
        /// <summary>http://erlangen-crm.org/110404/E17_Type_Assignment</summary>
        public const String E17 = NS + "E17_Type_Assignment";
        /// <summary>http://erlangen-crm.org/110404/E18_Physical_Thing</summary>
        public const String E18 = NS + "E18_Physical_Thing";
        /// <summary>http://erlangen-crm.org/110404/E19_Physical_Object</summary>
        public const String E19 = NS + "E19_Physical_Object";
        /// <summary>http://erlangen-crm.org/110404/E20_Biological_Object</summary>
        public const String E20 = NS + "E20_Biological_Object";
        /// <summary>http://erlangen-crm.org/110404/E21_Person</summary>
        public const String E21 = NS + "E21_Person";
        /// <summary>http://erlangen-crm.org/110404/E22_Man-Made_Object</summary>
        public const String E22 = NS + "E22_Man-Made_Object";
        /// <summary>http://erlangen-crm.org/110404/E24_Physical_Man-Made_Thing</summary>
        public const String E24 = NS + "E24_Physical_Man-Made_Thing";
        /// <summary>http://erlangen-crm.org/110404/E25_Man-Made_Feature</summary>
        public const String E25 = NS + "E25_Man-Made_Feature";
        /// <summary>http://erlangen-crm.org/110404/E26_Physical_Feature</summary>
        public const String E26 = NS + "E26_Physical_Feature";
        /// <summary>http://erlangen-crm.org/110404/E27_Site</summary>
        public const String E27 = NS + "E27_Site";
        /// <summary>http://erlangen-crm.org/110404/E28_Conceptual_Object</summary>
        public const String E28 = NS + "E28_Conceptual_Object";
        /// <summary>http://erlangen-crm.org/110404/E29_Design_or_Procedure</summary>
        public const String E29 = NS + "E29_Design_or_Procedure";
        /// <summary>http://erlangen-crm.org/110404/E30_Right</summary>
        public const String E30 = NS + "E30_Right";
        /// <summary>http://erlangen-crm.org/110404/E31_Document</summary>
        public const String E31 = NS + "E31_Document";
        /// <summary>http://erlangen-crm.org/110404/E32_Authority_Document</summary>
        public const String E32 = NS + "E32_Authority_Document";
        /// <summary>http://erlangen-crm.org/110404/E33_Linguistic_Object</summary>
        public const String E33 = NS + "E33_Linguistic_Object";
        /// <summary>http://erlangen-crm.org/110404/E34_Inscription</summary>
        public const String E34 = NS + "E34_Inscription";
        /// <summary>http://erlangen-crm.org/110404/E35_Title</summary>
        public const String E35 = NS + "E35_Title";
        /// <summary>http://erlangen-crm.org/110404/E36_Visual_Item</summary>
        public const String E36 = NS + "E36_Visual_Item";
        /// <summary>http://erlangen-crm.org/110404/E37_Mark</summary>
        public const String E37 = NS + "E37_Mark";
        /// <summary>http://erlangen-crm.org/110404/E38_Image</summary>
        public const String E38 = NS + "E38_Image";
        /// <summary>http://erlangen-crm.org/110404/E39_Actor</summary>
        public const String E39 = NS + "E39_Actor";
        /// <summary>http://erlangen-crm.org/110404/E40_Legal_Body</summary>
        public const String E40 = NS + "E40_Legal_Body";
        /// <summary>http://erlangen-crm.org/110404/E41_Appellation</summary>
        public const String E41 = NS + "E41_Appellation";
        /// <summary>http://erlangen-crm.org/110404/E42_Identifier</summary>
        public const String E42 = NS + "E42_Identifier";
        /// <summary>http://erlangen-crm.org/110404/E44_Place_Appellation</summary>
        public const String E44 = NS + "E44_Place_Appellation";
        /// <summary>http://erlangen-crm.org/110404/E45_Address</summary>
        public const String E45 = NS + "E45_Address";
        /// <summary>http://erlangen-crm.org/110404/E46_Section_Definition</summary>
        public const String E46 = NS + "E46_Section_Definition";
        /// <summary>http://erlangen-crm.org/110404/E47_Spatial_Coordinates</summary>
        public const String E47 = NS + "E47_Spatial_Coordinates";
        /// <summary>http://erlangen-crm.org/110404/E48_Place_Name</summary>
        public const String E48 = NS + "E48_Place_Name";
        /// <summary>http://erlangen-crm.org/110404/E49_Time_Appellation</summary>
        public const String E49 = NS + "E49_Time_Appellation";
        /// <summary>http://erlangen-crm.org/110404/E50_Date</summary>
        public const String E50 = NS + "E50_Date";
        /// <summary>http://erlangen-crm.org/110404/E51_Contact_Point</summary>
        public const String E51 = NS + "E51_Contact_Point";
        /// <summary>http://erlangen-crm.org/110404/E52_Time-Span</summary>
        public const String E52 = NS + "E52_Time-Span";
        /// <summary>http://erlangen-crm.org/110404/E53_Place</summary>
        public const String E53 = NS + "E53_Place";
        /// <summary>http://erlangen-crm.org/110404/E54_Dimension</summary>
        public const String E54 = NS + "E54_Dimension";
        /// <summary>http://erlangen-crm.org/110404/E55_Type</summary>
        public const String E55 = NS + "E55_Type";
        /// <summary>http://erlangen-crm.org/110404/E56_Language</summary>
        public const String E56 = NS + "E56_Language";
        /// <summary>http://erlangen-crm.org/110404/E57_Material</summary>
        public const String E57 = NS + "E57_Material";
        /// <summary>http://erlangen-crm.org/110404/E58_Measurement_Unit</summary>
        public const String E58 = NS + "E58_Measurement_Unit";
        /// <summary>http://erlangen-crm.org/110404/E59_Primitive_Value</summary>
        public const String E59 = NS + "E59_Primitive_Value";
        /// <summary>http://erlangen-crm.org/110404/E60_Number</summary>
        public const String E60 = NS + "E60_Number";
        /// <summary>http://erlangen-crm.org/110404/E61_Time_Primitive</summary>
        public const String E61 = NS + "E61_Time_Primitive";
        /// <summary>http://erlangen-crm.org/110404/E62_String</summary>
        public const String E62 = NS + "E62_String";
        /// <summary>http://erlangen-crm.org/110404/E63_Beginning_of_Existence</summary>
        public const String E63 = NS + "E63_Beginning_of_Existence";
        /// <summary>http://erlangen-crm.org/110404/E64_End_of_Existence</summary>
        public const String E64 = NS + "E64_End_of_Existence";
        /// <summary>http://erlangen-crm.org/110404/E65_Creation</summary>
        public const String E65 = NS + "E65_Creation";
        /// <summary>http://erlangen-crm.org/110404/E66_Formation</summary>
        public const String E66 = NS + "E66_Formation";
        /// <summary>http://erlangen-crm.org/110404/E67_Birth</summary>
        public const String E67 = NS + "E67_Birth";
        /// <summary>http://erlangen-crm.org/110404/E68_Dissolution</summary>
        public const String E68 = NS + "E68_Dissolution";
        /// <summary>http://erlangen-crm.org/110404/E69_Death</summary>
        public const String E69 = NS + "E69_Death";
        /// <summary>http://erlangen-crm.org/110404/E70_Thing</summary>
        public const String E70 = NS + "E70_Thing";
        /// <summary>http://erlangen-crm.org/110404/E71_Man-Made_Thing</summary>
        public const String E71 = NS + "E71_Man-Made_Thing";
        /// <summary>http://erlangen-crm.org/110404/E72_Legal_Object</summary>
        public const String E72 = NS + "E72_Legal_Object";
        /// <summary>http://erlangen-crm.org/110404/E73_Information_Object</summary>
        public const String E73 = NS + "E73_Information_Object";
        /// <summary>http://erlangen-crm.org/110404/E74_Group</summary>
        public const String E74 = NS + "E74_Group";
        /// <summary>http://erlangen-crm.org/110404/E75_Conceptual_Object_Appellation</summary>
        public const String E75 = NS + "E75_Conceptual_Object_Appellation";
        /// <summary>http://erlangen-crm.org/110404/E77_Persistent_Item</summary>
        public const String E77 = NS + "E77_Persistent_Item";
        /// <summary>http://erlangen-crm.org/110404/E78_Collection</summary>
        public const String E78 = NS + "E78_Collection";
        /// <summary>http://erlangen-crm.org/110404/E79_Part_Addition</summary>
        public const String E79 = NS + "E79_Part_Addition";
        /// <summary>http://erlangen-crm.org/110404/E80_Part_Removal</summary>
        public const String E80 = NS + "E80_Part_Removal";
        /// <summary>http://erlangen-crm.org/110404/E81_Transformation</summary>
        public const String E81 = NS + "E81_Transformation";
        /// <summary>http://erlangen-crm.org/110404/E82_Actor_Appellation</summary>
        public const String E82 = NS + "E82_Actor_Appellation";
        /// <summary>http://erlangen-crm.org/110404/E83_Type_Creation</summary>
        public const String E83 = NS + "E83_Type_Creation";
        /// <summary>http://erlangen-crm.org/110404/E84_Information_Carrier</summary>
        public const String E84 = NS + "E84_Information_Carrier";
        /// <summary>http://erlangen-crm.org/110404/E85_Joining</summary>
        public const String E85 = NS + "E85_Joining";
        /// <summary>http://erlangen-crm.org/110404/E86_Leaving</summary>
        public const String E86 = NS + "E86_Leaving";
        /// <summary>http://erlangen-crm.org/110404/E87_Curation_Activity</summary>
        public const String E87 = NS + "E87_Curation_Activity";
        /// <summary>http://erlangen-crm.org/110404/E89_Propositional_Object</summary>
        public const String E89 = NS + "E89_Propositional_Object";
        /// <summary>http://erlangen-crm.org/110404/E90_Symbolic_Object</summary>
        public const String E90 = NS + "E90_Symbolic_Object";
        #endregion

        #region properties
        /// <summary>http://erlangen-crm.org/110404/P1_is_identified_by</summary>
        public const String P1 = NS + "P1_is_identified_by";
        /// <summary>http://erlangen-crm.org/110404/P1i_identifies</summary>
        public const String P1i = NS + "P1i_identifies";
        /// <summary>http://erlangen-crm.org/110404/P2_has_type</summary>
        public const String P2 = NS + "P2_has_type";
        /// <summary>http://erlangen-crm.org/110404/P2i_is_type_of</summary>
        public const String P2i = NS + "P2i_is_type_of";
        /// <summary>http://erlangen-crm.org/110404/P3_has_note</summary>
        public const String P3 = NS + "P3_has_note";
        /// <summary>http://erlangen-crm.org/110404/P4_has_time-span</summary>
        public const String P4 = NS + "P4_has_time-span";
        /// <summary>http://erlangen-crm.org/110404/P4i_is_time-span_of</summary>
        public const String P4i = NS + "P4i_is_time-span_of";
        /// <summary>http://erlangen-crm.org/110404/P5_consists_of</summary>
        public const String P5 = NS + "P5_consists_of";
        /// <summary>http://erlangen-crm.org/110404/P5i_forms_part_of</summary>
        public const String P5i = NS + "P5i_forms_part_of";
        /// <summary>http://erlangen-crm.org/110404/P7_took_place_at</summary>
        public const String P7 = NS + "P7_took_place_at";
        /// <summary>http://erlangen-crm.org/110404/P7i_witnessed</summary>
        public const String P7i = NS + "P7i_witnessed";
        /// <summary>http://erlangen-crm.org/110404/P8_took_place_on_or_within</summary>
        public const String P8 = NS + "P8_took_place_on_or_within";
        /// <summary>http://erlangen-crm.org/110404/P8i_witnessed</summary>
        public const String P8i = NS + "P8i_witnessed";
        /// <summary>http://erlangen-crm.org/110404/P9_consists_of</summary>
        public const String P9 = NS + "P9_consists_of";
        /// <summary>http://erlangen-crm.org/110404/P9i_forms_part_of</summary>
        public const String P9i = NS + "P9i_forms_part_of";
        /// <summary>http://erlangen-crm.org/110404/P10_falls_within</summary>
        public const String P10 = NS + "P10_falls_within";
        /// <summary>http://erlangen-crm.org/110404/P10i_contains</summary>
        public const String P10i = NS + "P10i_contains";
        /// <summary>http://erlangen-crm.org/110404/P11_had_participant</summary>
        public const String P11 = NS + "P11_had_participant";
        /// <summary>http://erlangen-crm.org/110404/P11i_participated_in</summary>
        public const String P11i = NS + "P11i_participated_in";
        /// <summary>http://erlangen-crm.org/110404/P12_occurred_in_the_presence_of</summary>
        public const String P12 = NS + "P12_occurred_in_the_presence_of";
        /// <summary>http://erlangen-crm.org/110404/P12i_was_present_at</summary>
        public const String P12i = NS + "P12i_was_present_at";
        /// <summary>http://erlangen-crm.org/110404/P13_destroyed</summary>
        public const String P13 = NS + "P13_destroyed";
        /// <summary>http://erlangen-crm.org/110404/P13i_was_destroyed_by</summary>
        public const String P13i = NS + "P13i_was_destroyed_by";
        /// <summary>http://erlangen-crm.org/110404/P14_carried_out_by</summary>
        public const String P14 = NS + "P14_carried_out_by";
        /// <summary>http://erlangen-crm.org/110404/P14i_performed</summary>
        public const String P14i = NS + "P14i_performed";
        /// <summary>http://erlangen-crm.org/110404/P15_was_influenced_by</summary>
        public const String P15 = NS + "P15_was_influenced_by";
        /// <summary>http://erlangen-crm.org/110404/P15i_influenced</summary>
        public const String P15i = NS + "P15i_influenced";
        /// <summary>http://erlangen-crm.org/110404/P16_used_specific_object</summary>
        public const String P16 = NS + "P16_used_specific_object";
        /// <summary>http://erlangen-crm.org/110404/P16i_was_used_for</summary>
        public const String P16i = NS + "P16i_was_used_for";
        /// <summary>http://erlangen-crm.org/110404/P17_was_motivated_by</summary>
        public const String P17 = NS + "P17_was_motivated_by";
        /// <summary>http://erlangen-crm.org/110404/P17i_motivated</summary>
        public const String P17i = NS + "P17i_motivated";
        /// <summary>http://erlangen-crm.org/110404/P19_was_intended_use_of</summary>
        public const String P19 = NS + "P19_was_intended_use_of";
        /// <summary>http://erlangen-crm.org/110404/P19i_was_made_for</summary>
        public const String P19i = NS + "P19i_was_made_for";
        /// <summary>http://erlangen-crm.org/110404/P20_had_specific_purpose</summary>
        public const String P20 = NS + "P20_had_specific_purpose";
        /// <summary>http://erlangen-crm.org/110404/P20i_was_purpose_of</summary>
        public const String P20i = NS + "P20i_was_purpose_of";
        /// <summary>http://erlangen-crm.org/110404/P21_had_general_purpose</summary>
        public const String P21 = NS + "P21_had_general_purpose";
        /// <summary>http://erlangen-crm.org/110404/P21i_was_purpose_of</summary>
        public const String P21i = NS + "P21i_was_purpose_of";
        /// <summary>http://erlangen-crm.org/110404/P22_transferred_title_to</summary>
        public const String P22 = NS + "P22_transferred_title_to";
        /// <summary>http://erlangen-crm.org/110404/P22i_acquired_title_through</summary>
        public const String P22i = NS + "P22i_acquired_title_through";
        /// <summary>http://erlangen-crm.org/110404/P23_transferred_title_from</summary>
        public const String P23 = NS + "P23_transferred_title_from";
        /// <summary>http://erlangen-crm.org/110404/P23i_surrendered_title_through</summary>
        public const String P23i = NS + "P23i_surrendered_title_through";
        /// <summary>http://erlangen-crm.org/110404/P24_transferred_title_of</summary>
        public const String P24 = NS + "P24_transferred_title_of";
        /// <summary>http://erlangen-crm.org/110404/P24i_changed_ownership_through</summary>
        public const String P24i = NS + "P24i_changed_ownership_through";
        /// <summary>http://erlangen-crm.org/110404/P25_moved</summary>
        public const String P25 = NS + "P25_moved";
        /// <summary>http://erlangen-crm.org/110404/P25i_moved_by</summary>
        public const String P25i = NS + "P25i_moved_by";
        /// <summary>http://erlangen-crm.org/110404/P26_moved_to</summary>
        public const String P26 = NS + "P26_moved_to";
        /// <summary>http://erlangen-crm.org/110404/P26i_was_destination_of</summary>
        public const String P26i = NS + "P26i_was_destination_of";
        /// <summary>http://erlangen-crm.org/110404/P27_moved_from</summary>
        public const String P27 = NS + "P27_moved_from";
        /// <summary>http://erlangen-crm.org/110404/P27i_was_origin_of</summary>
        public const String P27i = NS + "P27i_was_origin_of";
        /// <summary>http://erlangen-crm.org/110404/P28_custody_surrendered_by</summary>
        public const String P28 = NS + "P28_custody_surrendered_by";
        /// <summary>http://erlangen-crm.org/110404/P28i_surrendered_custody_through</summary>
        public const String P28i = NS + "P28i_surrendered_custody_through";
        /// <summary>http://erlangen-crm.org/110404/P29_custody_received_by</summary>
        public const String P29 = NS + "P29_custody_received_by";
        /// <summary>http://erlangen-crm.org/110404/P29i_received_custody_through</summary>
        public const String P29i = NS + "P29i_received_custody_through";
        /// <summary>http://erlangen-crm.org/110404/P30_transferred_custody_of</summary>
        public const String P30 = NS + "P30_transferred_custody_of";
        /// <summary>http://erlangen-crm.org/110404/P30i_custody_transferred_through</summary>
        public const String P30i = NS + "P30i_custody_transferred_through";
        /// <summary>http://erlangen-crm.org/110404/P31_has_modified</summary>
        public const String P31 = NS + "P31_has_modified";
        /// <summary>http://erlangen-crm.org/110404/P31i_was_modified_by</summary>
        public const String P31i = NS + "P31i_was_modified_by";
        /// <summary>http://erlangen-crm.org/110404/P32_used_general_technique</summary>
        public const String P32 = NS + "P32_used_general_technique";
        /// <summary>http://erlangen-crm.org/110404/P32i_was_technique_of</summary>
        public const String P32i = NS + "P32i_was_technique_of";
        /// <summary>http://erlangen-crm.org/110404/P33_used_specific_technique</summary>
        public const String P33 = NS + "P33_used_specific_technique";
        /// <summary>http://erlangen-crm.org/110404/P33i_was_used_by</summary>
        public const String P33i = NS + "P33i_was_used_by";
        /// <summary>http://erlangen-crm.org/110404/P34_concerned</summary>
        public const String P34 = NS + "P34_concerned";
        /// <summary>http://erlangen-crm.org/110404/P34i_was_assessed_by</summary>
        public const String P34i = NS + "P34i_was_assessed_by";
        /// <summary>http://erlangen-crm.org/110404/P35_has_identified</summary>
        public const String P35 = NS + "P35_has_identified";
        /// <summary>http://erlangen-crm.org/110404/P35i_was_identified_by</summary>
        public const String P35i = NS + "P35i_was_identified_by";
        /// <summary>http://erlangen-crm.org/110404/P37_assigned</summary>
        public const String P37 = NS + "P37_assigned";
        /// <summary>http://erlangen-crm.org/110404/P37i_was_assigned_by</summary>
        public const String P37i = NS + "P37i_was_assigned_by";
        /// <summary>http://erlangen-crm.org/110404/P38_deassigned</summary>
        public const String P38 = NS + "P38_deassigned";
        /// <summary>http://erlangen-crm.org/110404/P38i_was_deassigned_by</summary>
        public const String P38i = NS + "P38i_was_deassigned_by";
        /// <summary>http://erlangen-crm.org/110404/P39_measured</summary>
        public const String P39 = NS + "P39_measured";
        /// <summary>http://erlangen-crm.org/110404/P39i_was_measured_by</summary>
        public const String P39i = NS + "P39i_was_measured_by";
        /// <summary>http://erlangen-crm.org/110404/P40_observed_dimension</summary>
        public const String P40 = NS + "P40_observed_dimension";
        /// <summary>http://erlangen-crm.org/110404/P40i_was_observed_in</summary>
        public const String P40i = NS + "P40i_was_observed_in";
        /// <summary>http://erlangen-crm.org/110404/P41_classified</summary>
        public const String P41 = NS + "P41_classified";
        /// <summary>http://erlangen-crm.org/110404/P41i_was_classified_by</summary>
        public const String P41i = NS + "P41i_was_classified_by";
        /// <summary>http://erlangen-crm.org/110404/P42_assigned</summary>
        public const String P42 = NS + "P42_assigned";
        /// <summary>http://erlangen-crm.org/110404/P42i_was_assigned_by</summary>
        public const String P42i = NS + "P42i_was_assigned_by";
        /// <summary>http://erlangen-crm.org/110404/P43_has_dimension</summary>
        public const String P43 = NS + "P43_has_dimension";
        /// <summary>http://erlangen-crm.org/110404/P43i_is_dimension_of</summary>
        public const String P43i = NS + "P43i_is_dimension_of";
        /// <summary>http://erlangen-crm.org/110404/P44_has_condition</summary>
        public const String P44 = NS + "P44_has_condition";
        /// <summary>http://erlangen-crm.org/110404/P44i_is_condition_of</summary>
        public const String P44i = NS + "P44i_is_condition_of";
        /// <summary>http://erlangen-crm.org/110404/P45_consists_of</summary>
        public const String P45 = NS + "P45_consists_of";
        /// <summary>http://erlangen-crm.org/110404/P45i_is_incorporated_in</summary>
        public const String P45i = NS + "P45i_is_incorporated_in";
        /// <summary>http://erlangen-crm.org/110404/P46_is_composed_of</summary>
        public const String P46 = NS + "P46_is_composed_of";
        /// <summary>http://erlangen-crm.org/110404/P46i_forms_part_of</summary>
        public const String P46i = NS + "P46i_forms_part_of";
        /// <summary>http://erlangen-crm.org/110404/P48_has_preferred_identifier</summary>
        public const String P48 = NS + "P48_has_preferred_identifier";
        /// <summary>http://erlangen-crm.org/110404/P48i_is_preferred_identifier_of</summary>
        public const String P48i = NS + "P48i_is_preferred_identifier_of";
        /// <summary>http://erlangen-crm.org/110404/P49_has_former_or_current_keeper</summary>
        public const String P49 = NS + "P49_has_former_or_current_keeper";
        /// <summary>http://erlangen-crm.org/110404/P49i_is_former_or_current_keeper_of</summary>
        public const String P49i = NS + "P49i_is_former_or_current_keeper_of";
        /// <summary>http://erlangen-crm.org/110404/P50_has_current_keeper</summary>
        public const String P50 = NS + "P50_has_current_keeper";
        /// <summary>http://erlangen-crm.org/110404/P50i_is_current_keeper_of</summary>
        public const String P50i = NS + "P50i_is_current_keeper_of";
        /// <summary>http://erlangen-crm.org/110404/P51_has_former_or_current_owner</summary>
        public const String P51 = NS + "P51_has_former_or_current_owner";
        /// <summary>http://erlangen-crm.org/110404/P51i_is_former_or_current_owner_of</summary>
        public const String P51i = NS + "P51i_is_former_or_current_owner_of";
        /// <summary>http://erlangen-crm.org/110404/P52_has_current_owner</summary>
        public const String P52 = NS + "P52_has_current_owner";
        /// <summary>http://erlangen-crm.org/110404/P52i_is_current_owner_of</summary>
        public const String P52i = NS + "P52i_is_current_owner_of";
        /// <summary>http://erlangen-crm.org/110404/P53_has_former_or_current_location</summary>
        public const String P53 = NS + "P53_has_former_or_current_location";
        /// <summary>http://erlangen-crm.org/110404/P53i_is_former_or_current_location_of</summary>
        public const String P53i = NS + "P53i_is_former_or_current_location_of";
        /// <summary>http://erlangen-crm.org/110404/P54_has_current_permanent_location</summary>
        public const String P54 = NS + "P54_has_current_permanent_location";
        /// <summary>http://erlangen-crm.org/110404/P54i_is_current_permanent_location_of</summary>
        public const String P54i = NS + "P54i_is_current_permanent_location_of";
        /// <summary>http://erlangen-crm.org/110404/P55_has_current_location</summary>
        public const String P55 = NS + "P55_has_current_location";
        /// <summary>http://erlangen-crm.org/110404/P55i_currently_holds</summary>
        public const String P55i = NS + "P55i_currently_holds";
        /// <summary>http://erlangen-crm.org/110404/P56_bears_feature</summary>
        public const String P56 = NS + "P56_bears_feature";
        /// <summary>http://erlangen-crm.org/110404/P56i_is_found_on</summary>
        public const String P56i = NS + "P56i_is_found_on";
        /// <summary>http://erlangen-crm.org/110404/P57_has_number_of_parts</summary>
        public const String P57 = NS + "P57_has_number_of_parts";
        /// <summary>http://erlangen-crm.org/110404/P58_has_section_definition</summary>
        public const String P58 = NS + "P58_has_section_definition";
        /// <summary>http://erlangen-crm.org/110404/P58i_defines_section</summary>
        public const String P58i = NS + "P58i_defines_section";
        /// <summary>http://erlangen-crm.org/110404/P59_has_section</summary>
        public const String P59 = NS + "P59_has_section";
        /// <summary>http://erlangen-crm.org/110404/P59i_is_located_on_or_within</summary>
        public const String P59i = NS + "P59i_is_located_on_or_within";
        /// <summary>http://erlangen-crm.org/110404/P62_depicts</summary>
        public const String P62 = NS + "P62_depicts";
        /// <summary>http://erlangen-crm.org/110404/P62i_is_depicted_by</summary>
        public const String P62i = NS + "P62i_is_depicted_by";
        /// <summary>http://erlangen-crm.org/110404/P65_shows_visual_item</summary>
        public const String P65 = NS + "P65_shows_visual_item";
        /// <summary>http://erlangen-crm.org/110404/P65i_is_shown_by</summary>
        public const String P65i = NS + "P65i_is_shown_by";
        /// <summary>http://erlangen-crm.org/110404/P67_refers_to</summary>
        public const String P67 = NS + "P67_refers_to";
        /// <summary>http://erlangen-crm.org/110404/P67i_is_referred_to_by</summary>
        public const String P67i = NS + "P67i_is_referred_to_by";
        /// <summary>http://erlangen-crm.org/110404/P68_foresees_use_of</summary>
        public const String P68 = NS + "P68_foresees_use_of";
        /// <summary>http://erlangen-crm.org/110404/P68i_use_foreseen_by</summary>
        public const String P68i = NS + "P68i_use_foreseen_by";
        /// <summary>http://erlangen-crm.org/110404/P69_is_associated_with</summary>
        public const String P69 = NS + "P69_is_associated_with";
        /// <summary>http://erlangen-crm.org/110404/P70_documents</summary>
        public const String P70 = NS + "P70_documents";
        /// <summary>http://erlangen-crm.org/110404/P70i_is_documented_in</summary>
        public const String P70i = NS + "P70i_is_documented_in";
        /// <summary>http://erlangen-crm.org/110404/P71_lists</summary>
        public const String P71 = NS + "P71_lists";
        /// <summary>http://erlangen-crm.org/110404/P71i_is_listed_in</summary>
        public const String P71i = NS + "P71i_is_listed_in";
        /// <summary>http://erlangen-crm.org/110404/P72_has_language</summary>
        public const String P72 = NS + "P72_has_language";
        /// <summary>http://erlangen-crm.org/110404/P72i_is_language_of</summary>
        public const String P72i = NS + "P72i_is_language_of";
        /// <summary>http://erlangen-crm.org/110404/P73_has_translation</summary>
        public const String P73 = NS + "P73_has_translation";
        /// <summary>http://erlangen-crm.org/110404/P73i_is_translation_of</summary>
        public const String P73i = NS + "P73i_is_translation_of";
        /// <summary>http://erlangen-crm.org/110404/P74_has_current_or_former_residence</summary>
        public const String P74 = NS + "P74_has_current_or_former_residence";
        /// <summary>http://erlangen-crm.org/110404/P74i_is_current_or_former_residence_of</summary>
        public const String P74i = NS + "P74i_is_current_or_former_residence_of";
        /// <summary>http://erlangen-crm.org/110404/P75_possesses</summary>
        public const String P75 = NS + "P75_possesses";
        /// <summary>http://erlangen-crm.org/110404/P75i_is_possessed_by</summary>
        public const String P75i = NS + "P75i_is_possessed_by";
        /// <summary>http://erlangen-crm.org/110404/P76_has_contact_point</summary>
        public const String P76 = NS + "P76_has_contact_point";
        /// <summary>http://erlangen-crm.org/110404/P76i_provides_access_to</summary>
        public const String P76i = NS + "P76i_provides_access_to";
        /// <summary>http://erlangen-crm.org/110404/P78_is_identified_by</summary>
        public const String P78 = NS + "P78_is_identified_by";
        /// <summary>http://erlangen-crm.org/110404/P78i_identifies</summary>
        public const String P78i = NS + "P78i_identifies";
        /// <summary>http://erlangen-crm.org/110404/P79_beginning_is_qualified_by</summary>
        public const String P79 = NS + "P79_beginning_is_qualified_by";
        /// <summary>http://erlangen-crm.org/110404/P80_end_is_qualified_by</summary>
        public const String P80 = NS + "P80_end_is_qualified_by";
        /// <summary>http://erlangen-crm.org/110404/P81_ongoing_throughout</summary>
        public const String P81 = NS + "P81_ongoing_throughout";
        /// <summary>http://erlangen-crm.org/110404/P82_at_some_time_within</summary>
        public const String P82 = NS + "P82_at_some_time_within";
        /// <summary>http://erlangen-crm.org/110404/P83_had_at_least_duration</summary>
        public const String P83 = NS + "P83_had_at_least_duration";
        /// <summary>http://erlangen-crm.org/110404/P83i_was_minimum_duration_of</summary>
        public const String P83i = NS + "P83i_was_minimum_duration_of";
        /// <summary>http://erlangen-crm.org/110404/P84_had_at_most_duration</summary>
        public const String P84 = NS + "P84_had_at_most_duration";
        /// <summary>http://erlangen-crm.org/110404/P84i_was_maximum_duration_of</summary>
        public const String P84i = NS + "P84i_was_maximum_duration_of";
        /// <summary>http://erlangen-crm.org/110404/P86_falls_within</summary>
        public const String P86 = NS + "P86_falls_within";
        /// <summary>http://erlangen-crm.org/110404/P86i_contains</summary>
        public const String P86i = NS + "P86i_contains";
        /// <summary>http://erlangen-crm.org/110404/P87_is_identified_by</summary>
        public const String P87 = NS + "P87_is_identified_by";
        /// <summary>http://erlangen-crm.org/110404/P87i_identifies</summary>
        public const String P87i = NS + "P87i_identifies";
        /// <summary>http://erlangen-crm.org/110404/P88_consists_of</summary>
        public const String P88 = NS + "P88_consists_of";
        /// <summary>http://erlangen-crm.org/110404/P88i_forms_part_of</summary>
        public const String P88i = NS + "P88i_forms_part_of";
        /// <summary>http://erlangen-crm.org/110404/P89_falls_within</summary>
        public const String P89 = NS + "P89_falls_within";
        /// <summary>http://erlangen-crm.org/110404/P89i_contains</summary>
        public const String P89i = NS + "P89i_contains";
        /// <summary>http://erlangen-crm.org/110404/P90_has_value</summary>
        public const String P90 = NS + "P90_has_value";
        /// <summary>http://erlangen-crm.org/110404/P91_has_unit</summary>
        public const String P91 = NS + "P91_has_unit";
        /// <summary>http://erlangen-crm.org/110404/P91i_is_unit_of</summary>
        public const String P91i = NS + "P91i_is_unit_of";
        /// <summary>http://erlangen-crm.org/110404/P92_brought_into_existence</summary>
        public const String P92 = NS + "P92_brought_into_existence";
        /// <summary>http://erlangen-crm.org/110404/P92i_was_brought_into_existence_by</summary>
        public const String P92i = NS + "P92i_was_brought_into_existence_by";
        /// <summary>http://erlangen-crm.org/110404/P93_took_out_of_existence</summary>
        public const String P93 = NS + "P93_took_out_of_existence";
        /// <summary>http://erlangen-crm.org/110404/P93i_was_taken_out_of_existence_by</summary>
        public const String P93i = NS + "P93i_was_taken_out_of_existence_by";
        /// <summary>http://erlangen-crm.org/110404/P94_has_created</summary>
        public const String P94 = NS + "P94_has_created";
        /// <summary>http://erlangen-crm.org/110404/P94i_was_created_by</summary>
        public const String P94i = NS + "P94i_was_created_by";
        /// <summary>http://erlangen-crm.org/110404/P95_has_formed</summary>
        public const String P95 = NS + "P95_has_formed";
        /// <summary>http://erlangen-crm.org/110404/P95i_was_formed_by</summary>
        public const String P95i = NS + "P95i_was_formed_by";
        /// <summary>http://erlangen-crm.org/110404/P96_by_mother</summary>
        public const String P96 = NS + "P96_by_mother";
        /// <summary>http://erlangen-crm.org/110404/P96i_gave_birth</summary>
        public const String P96i = NS + "P96i_gave_birth";
        /// <summary>http://erlangen-crm.org/110404/P97_from_father</summary>
        public const String P97 = NS + "P97_from_father";
        /// <summary>http://erlangen-crm.org/110404/P97i_was_father_for</summary>
        public const String P97i = NS + "P97i_was_father_for";
        /// <summary>http://erlangen-crm.org/110404/P98_brought_into_life</summary>
        public const String P98 = NS + "P98_brought_into_life";
        /// <summary>http://erlangen-crm.org/110404/P98i_was_born</summary>
        public const String P98i = NS + "P98i_was_born";
        /// <summary>http://erlangen-crm.org/110404/P99_dissolved</summary>
        public const String P99 = NS + "P99_dissolved";
        /// <summary>http://erlangen-crm.org/110404/P99i_was_dissolved_by</summary>
        public const String P99i = NS + "P99i_was_dissolved_by";
        /// <summary>http://erlangen-crm.org/110404/P100_was_death_of</summary>
        public const String P100 = NS + "P100_was_death_of";
        /// <summary>http://erlangen-crm.org/110404/P100i_died_in</summary>
        public const String P100i = NS + "P100i_died_in";
        /// <summary>http://erlangen-crm.org/110404/P101_had_as_general_use</summary>
        public const String P101 = NS + "P101_had_as_general_use";
        /// <summary>http://erlangen-crm.org/110404/P101i_was_use_of</summary>
        public const String P101i = NS + "P101i_was_use_of";
        /// <summary>http://erlangen-crm.org/110404/P102_has_title</summary>
        public const String P102 = NS + "P102_has_title";
        /// <summary>http://erlangen-crm.org/110404/P102i_is_title_of</summary>
        public const String P102i = NS + "P102i_is_title_of";
        /// <summary>http://erlangen-crm.org/110404/P103_was_intended_for</summary>
        public const String P103 = NS + "P103_was_intended_for";
        /// <summary>http://erlangen-crm.org/110404/P103i_was_intention_of</summary>
        public const String P103i = NS + "P103i_was_intention_of";
        /// <summary>http://erlangen-crm.org/110404/P104_is_subject_to</summary>
        public const String P104 = NS + "P104_is_subject_to";
        /// <summary>http://erlangen-crm.org/110404/P104i_applies_to</summary>
        public const String P104i = NS + "P104i_applies_to";
        /// <summary>http://erlangen-crm.org/110404/P105_right_held_by</summary>
        public const String P105 = NS + "P105_right_held_by";
        /// <summary>http://erlangen-crm.org/110404/P105i_has_right_on</summary>
        public const String P105i = NS + "P105i_has_right_on";
        /// <summary>http://erlangen-crm.org/110404/P106_is_composed_of</summary>
        public const String P106 = NS + "P106_is_composed_of";
        /// <summary>http://erlangen-crm.org/110404/P106i_forms_part_of</summary>
        public const String P106i = NS + "P106i_forms_part_of";
        /// <summary>http://erlangen-crm.org/110404/P107_has_current_or_former_member</summary>
        public const String P107 = NS + "P107_has_current_or_former_member";
        /// <summary>http://erlangen-crm.org/110404/P107i_is_current_or_former_member_of</summary>
        public const String P107i = NS + "P107i_is_current_or_former_member_of";
        /// <summary>http://erlangen-crm.org/110404/P108_has_produced</summary>
        public const String P108 = NS + "P108_has_produced";
        /// <summary>http://erlangen-crm.org/110404/P108i_was_produced_by</summary>
        public const String P108i = NS + "P108i_was_produced_by";
        /// <summary>http://erlangen-crm.org/110404/P109_has_current_or_former_curator</summary>
        public const String P109 = NS + "P109_has_current_or_former_curator";
        /// <summary>http://erlangen-crm.org/110404/P109i_is_current_or_former_curator_of</summary>
        public const String P109i = NS + "P109i_is_current_or_former_curator_of";
        /// <summary>http://erlangen-crm.org/110404/P110_augmented</summary>
        public const String P110 = NS + "P110_augmented";
        /// <summary>http://erlangen-crm.org/110404/P110i_was_augmented_by</summary>
        public const String P110i = NS + "P110i_was_augmented_by";
        /// <summary>http://erlangen-crm.org/110404/P111_added</summary>
        public const String P111 = NS + "P111_added";
        /// <summary>http://erlangen-crm.org/110404/P111i_was_added_by</summary>
        public const String P111i = NS + "P111i_was_added_by";
        /// <summary>http://erlangen-crm.org/110404/P112_diminished</summary>
        public const String P112 = NS + "P112_diminished";
        /// <summary>http://erlangen-crm.org/110404/P112i_was_diminished_by</summary>
        public const String P112i = NS + "P112i_was_diminished_by";
        /// <summary>http://erlangen-crm.org/110404/P113_removed</summary>
        public const String P113 = NS + "P113_removed";
        /// <summary>http://erlangen-crm.org/110404/P113i_was_removed_by</summary>
        public const String P113i = NS + "P113i_was_removed_by";
        /// <summary>http://erlangen-crm.org/110404/P114_is_equal_in_time_to</summary>
        public const String P114 = NS + "P114_is_equal_in_time_to";
        /// <summary>http://erlangen-crm.org/110404/P115_finishes</summary>
        public const String P115 = NS + "P115_finishes";
        /// <summary>http://erlangen-crm.org/110404/P115i_is_finished_by</summary>
        public const String P115i = NS + "P115i_is_finished_by";
        /// <summary>http://erlangen-crm.org/110404/P116_starts</summary>
        public const String P116 = NS + "P116_starts";
        /// <summary>http://erlangen-crm.org/110404/P116i_is_started_by</summary>
        public const String P116i = NS + "P116i_is_started_by";
        /// <summary>http://erlangen-crm.org/110404/P117_occurs_during</summary>
        public const String P117 = NS + "P117_occurs_during";
        /// <summary>http://erlangen-crm.org/110404/P117i_includes</summary>
        public const String P117i = NS + "P117i_includes";
        /// <summary>http://erlangen-crm.org/110404/P118_overlaps_in_time_with</summary>
        public const String P118 = NS + "P118_overlaps_in_time_with";
        /// <summary>http://erlangen-crm.org/110404/P118i_is_overlapped_in_time_by</summary>
        public const String P118i = NS + "P118i_is_overlapped_in_time_by";
        /// <summary>http://erlangen-crm.org/110404/P119_meets_in_time_with</summary>
        public const String P119 = NS + "P119_meets_in_time_with";
        /// <summary>http://erlangen-crm.org/110404/P119i_is_met_in_time_by</summary>
        public const String P119i = NS + "P119i_is_met_in_time_by";
        /// <summary>http://erlangen-crm.org/110404/P120_occurs_before</summary>
        public const String P120 = NS + "P120_occurs_before";
        /// <summary>http://erlangen-crm.org/110404/P120i_occurs_after</summary>
        public const String P120i = NS + "P120i_occurs_after";
        /// <summary>http://erlangen-crm.org/110404/P121_overlaps_with</summary>
        public const String P121 = NS + "P121_overlaps_with";
        /// <summary>http://erlangen-crm.org/110404/P122_borders_with</summary>
        public const String P122 = NS + "P122_borders_with";
        /// <summary>http://erlangen-crm.org/110404/P123_resulted_in</summary>
        public const String P123 = NS + "P123_resulted_in";
        /// <summary>http://erlangen-crm.org/110404/P123i_resulted_from</summary>
        public const String P123i = NS + "P123i_resulted_from";
        /// <summary>http://erlangen-crm.org/110404/P124_transformed</summary>
        public const String P124 = NS + "P124_transformed";
        /// <summary>http://erlangen-crm.org/110404/P124i_was_transformed_by</summary>
        public const String P124i = NS + "P124i_was_transformed_by";
        /// <summary>http://erlangen-crm.org/110404/P125_used_object_of_type</summary>
        public const String P125 = NS + "P125_used_object_of_type";
        /// <summary>http://erlangen-crm.org/110404/P125i_was_type_of_object_used_in</summary>
        public const String P125i = NS + "P125i_was_type_of_object_used_in";
        /// <summary>http://erlangen-crm.org/110404/P126_employed</summary>
        public const String P126 = NS + "P126_employed";
        /// <summary>http://erlangen-crm.org/110404/P126i_was_employed_in</summary>
        public const String P126i = NS + "P126i_was_employed_in";
        /// <summary>http://erlangen-crm.org/110404/P127_has_broader_term</summary>
        public const String P127 = NS + "P127_has_broader_term";
        /// <summary>http://erlangen-crm.org/110404/P127i_has_narrower_term</summary>
        public const String P127i = NS + "P127i_has_narrower_term";
        /// <summary>http://erlangen-crm.org/110404/P128_carries</summary>
        public const String P128 = NS + "P128_carries";
        /// <summary>http://erlangen-crm.org/110404/P128i_is_carried_by</summary>
        public const String P128i = NS + "P128i_is_carried_by";
        /// <summary>http://erlangen-crm.org/110404/P129_is_about</summary>
        public const String P129 = NS + "P129_is_about";
        /// <summary>http://erlangen-crm.org/110404/P129i_is_subject_of</summary>
        public const String P129i = NS + "P129i_is_subject_of";
        /// <summary>http://erlangen-crm.org/110404/P130_shows_features_of</summary>
        public const String P130 = NS + "P130_shows_features_of";
        /// <summary>http://erlangen-crm.org/110404/P130i_features_are_also_found_on</summary>
        public const String P130i = NS + "P130i_features_are_also_found_on";
        /// <summary>http://erlangen-crm.org/110404/P131_is_identified_by</summary>
        public const String P131 = NS + "P131_is_identified_by";
        /// <summary>http://erlangen-crm.org/110404/P131i_identifies</summary>
        public const String P131i = NS + "P131i_identifies";
        /// <summary>http://erlangen-crm.org/110404/P132_overlaps_with</summary>
        public const String P132 = NS + "P132_overlaps_with";
        /// <summary>http://erlangen-crm.org/110404/P133_is_separated_from</summary>
        public const String P133 = NS + "P133_is_separated_from";
        /// <summary>http://erlangen-crm.org/110404/P134_continued</summary>
        public const String P134 = NS + "P134_continued";
        /// <summary>http://erlangen-crm.org/110404/P134i_was_continued_by</summary>
        public const String P134i = NS + "P134i_was_continued_by";
        /// <summary>http://erlangen-crm.org/110404/P135_created_type</summary>
        public const String P135 = NS + "P135_created_type";
        /// <summary>http://erlangen-crm.org/110404/P135i_was_created_by</summary>
        public const String P135i = NS + "P135i_was_created_by";
        /// <summary>http://erlangen-crm.org/110404/P136_was_based_on</summary>
        public const String P136 = NS + "P136_was_based_on";
        /// <summary>http://erlangen-crm.org/110404/P136i_supported_type_creation</summary>
        public const String P136i = NS + "P136i_supported_type_creation";
        /// <summary>http://erlangen-crm.org/110404/P137_exemplifies</summary>
        public const String P137 = NS + "P137_exemplifies";
        /// <summary>http://erlangen-crm.org/110404/P137i_is_exemplified_by</summary>
        public const String P137i = NS + "P137i_is_exemplified_by";
        /// <summary>http://erlangen-crm.org/110404/P138_represents</summary>
        public const String P138 = NS + "P138_represents";
        /// <summary>http://erlangen-crm.org/110404/P138i_has_representation</summary>
        public const String P138i = NS + "P138i_has_representation";
        /// <summary>http://erlangen-crm.org/110404/P139_has_alternative_form</summary>
        public const String P139 = NS + "P139_has_alternative_form";
        /// <summary>http://erlangen-crm.org/110404/P140_assigned_attribute_to</summary>
        public const String P140 = NS + "P140_assigned_attribute_to";
        /// <summary>http://erlangen-crm.org/110404/P140i_was_attributed_by</summary>
        public const String P140i = NS + "P140i_was_attributed_by";
        /// <summary>http://erlangen-crm.org/110404/P141_assigned</summary>
        public const String P141 = NS + "P141_assigned";
        /// <summary>http://erlangen-crm.org/110404/P141i_was_assigned_by</summary>
        public const String P141i = NS + "P141i_was_assigned_by";
        /// <summary>http://erlangen-crm.org/110404/P142_used_constituent</summary>
        public const String P142 = NS + "P142_used_constituent";
        /// <summary>http://erlangen-crm.org/110404/P142i_was_used_in</summary>
        public const String P142i = NS + "P142i_was_used_in";
        /// <summary>http://erlangen-crm.org/110404/P143_joined</summary>
        public const String P143 = NS + "P143_joined";
        /// <summary>http://erlangen-crm.org/110404/P143i_was_joined_by</summary>
        public const String P143i = NS + "P143i_was_joined_by";
        /// <summary>http://erlangen-crm.org/110404/P144_joined_with</summary>
        public const String P144 = NS + "P144_joined_with";
        /// <summary>http://erlangen-crm.org/110404/P144i_gained_member_by</summary>
        public const String P144i = NS + "P144i_gained_member_by";
        /// <summary>http://erlangen-crm.org/110404/P145_separated</summary>
        public const String P145 = NS + "P145_separated";
        /// <summary>http://erlangen-crm.org/110404/P145i_left_by</summary>
        public const String P145i = NS + "P145i_left_by";
        /// <summary>http://erlangen-crm.org/110404/P146_separated_from</summary>
        public const String P146 = NS + "P146_separated_from";
        /// <summary>http://erlangen-crm.org/110404/P146i_lost_member_by</summary>
        public const String P146i = NS + "P146i_lost_member_by";
        /// <summary>http://erlangen-crm.org/110404/P147_curated</summary>
        public const String P147 = NS + "P147_curated";
        /// <summary>http://erlangen-crm.org/110404/P147i_was_curated_by</summary>
        public const String P147i = NS + "P147i_was_curated_by";
        /// <summary>http://erlangen-crm.org/110404/P148_has_component</summary>
        public const String P148 = NS + "P148_has_component";
        /// <summary>http://erlangen-crm.org/110404/P148i_is_component_of</summary>
        public const String P148i = NS + "P148i_is_component_of";
        #endregion
    }
}
