/*
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_CRM 
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    <script type="module">
        import {URI_CRM} from "./URI_CRM.js"
        console.log(URI_CRM.E1) | console.log(URI_CRM["E1"])
        # both return "http://www.cidoc-crm.org/cidoc-crm/E1_CRM_Entity"
    </script>
License : https://mit-license.org
History :
10/02/2023 CFB Extracted from old script and converted to ES6 module
===============================================================================
*/
const NS = "http://www.cidoc-crm.org/cidoc-crm/"
export const URI_CRM = Object.freeze({
    // entities
    E1: `${NS}E1_CRM_Entity`,
    E2: `${NS}E2_Temporal_Entity`,
    E3: `${NS}E3_Condition_State`,
    E4: `${NS}E4_Period`,
    E5: `${NS}E5_Event`,
    E6: `${NS}E6_Destruction`,
    E7: `${NS}E7_Activity`,
    E8: `${NS}E8_Acquisition`,
    E9: `${NS}E9_Move`,
    E10: `${NS}E10_Transfer_of_Custody`,
    E11: `${NS}E11_Modification`,
    E12: `${NS}E12_Production`,
    E13: `${NS}E13_Attribute_Assignment`,
    E14: `${NS}E14_Condition_Assessment`,
    E15: `${NS}E15_Identifier_Assignment`,
    E16: `${NS}E16_Measurement`,
    E17: `${NS}E17_Type_Assignment`,
    E18: `${NS}E18_Physical_Thing`,
    E19: `${NS}E19_Physical_Object`,
    E20: `${NS}E20_Biological_Object`,
    E21: `${NS}E21_Person`,
    E22: `${NS}E22_Man-Made_Object`,
    E24: `${NS}E24_Physical_Man-Made_Thing`,
    E25: `${NS}E25_Man-Made_Feature`,
    E26: `${NS}E26_Physical_Feature`,
    E27: `${NS}E27_Site`,
    E28: `${NS}E28_Conceptual_Object`,
    E29: `${NS}E29_Design_or_Procedure`,
    E30: `${NS}E30_Right`,
    E31: `${NS}E31_Document`,
    E32: `${NS}E32_Authority_Document`,
    E33: `${NS}E33_Linguistic_Object`,
    E34: `${NS}E34_Inscription`,
    E35: `${NS}E35_Title`,
    E36: `${NS}E36_Visual_Item`,
    E37: `${NS}E37_Mark`,
    E38: `${NS}E38_Image`,
    E39: `${NS}E39_Actor`,
    E40: `${NS}E40_Legal_Body`,
    E41: `${NS}E41_Appellation`,
    E42: `${NS}E42_Identifier`,
    E44: `${NS}E44_Place_Appellation`,
    E45: `${NS}E45_Address`,
    E46: `${NS}E46_Section_Definition`,
    E47: `${NS}E47_Spatial_Coordinates`,
    E48: `${NS}E48_Place_Name`,
    E49: `${NS}E49_Time_Appellation`,
    E50: `${NS}E50_Date`,
    E51: `${NS}E51_Contact_Point`,
    E52: `${NS}E52_Time-Span`,
    E53: `${NS}E53_Place`,
    E54: `${NS}E54_Dimension`,
    E55: `${NS}E55_Type`,
    E56: `${NS}E56_Language`,
    E57: `${NS}E57_Material`,
    E58: `${NS}E58_Measurement_Unit`,
    E59: `${NS}E59_PrimitiveValue`,
    E60: `${NS}E60_Number`,
    E61: `${NS}E61_Time_Primitive`,
    E62: `${NS}E62_String`,
    E63: `${NS}E63_Beginning_of_Existence`,
    E64: `${NS}E64_End_of_Existence`,
    E65: `${NS}E65_Creation`,
    E66: `${NS}E66_Formation`,
    E67: `${NS}E67_Birth`,
    E68: `${NS}E68_Dissolution`,
    E69: `${NS}E69_Death`,
    E70: `${NS}E70_Thing`,
    E71: `${NS}E71_Man-Made_Thing`,
    E72: `${NS}E72_Legal_Object`,
    E73: `${NS}E73_Information_Object`,
    E74: `${NS}E74_Group`,
    E75: `${NS}E75_Conceptual_Object_Appellation`,
    E77: `${NS}E77_Persistent_Item`,
    E78: `${NS}E78_Collection`,
    E79: `${NS}E79_Part_Addition`,
    E80: `${NS}E80_Part_Removal`,
    E81: `${NS}E81_Transformation`,
    E82: `${NS}E82_Actor_Appellation`,
    E83: `${NS}E83_Type_Creation`,
    E84: `${NS}E84_Information_Carrier`,
    E85: `${NS}E85_Joining`,
    E86: `${NS}E86_Leaving`,
    E87: `${NS}E87_Curation_Activity`,
    E89: `${NS}E89_Propositional_Object`,
    E90: `${NS}E90_Symbolic_Object`,
    // properties
    P1: `${NS}P1_is_identified_by`,
    P1i: `${NS}P1i_identifies`,
    P2: `${NS}P2_has_type`,
    P2i: `${NS}P2i_is_type_of`,
    P3: `${NS}P3_has_note`,
    P4: `${NS}P4_has_time-span`,
    P4i: `${NS}P4i_is_time-span_of`,
    P5: `${NS}P5_consists_of`,
    P5i: `${NS}P5i_forms_part_of`,
    P7: `${NS}P7_took_place_at`,
    P7i: `${NS}P7i_witnessed`,
    P8: `${NS}P8_took_place_on_or_within`,
    P8i: `${NS}P8i_witnessed`,
    P9: `${NS}P9_consists_of`,
    P9i: `${NS}P9i_forms_part_of`,
    P10: `${NS}P10_falls_within`,
    P10i: `${NS}P10i_contains`,
    P11: `${NS}P11_had_participant`,
    P11i: `${NS}P11i_participated_in`,
    P12: `${NS}P12_occurred_in_the_presence_of`,
    P12i: `${NS}P12i_was_present_at`,
    P13: `${NS}P13_destroyed`,
    P13i: `${NS}P13i_was_destroyed_by`,
    P14: `${NS}P14_carried_out_by`,
    P14i: `${NS}P14i_performed`,
    P15: `${NS}P15_was_influenced_by`,
    P15i: `${NS}P15i_influenced`,
    P16: `${NS}P16_used_specific_object`,
    P16i: `${NS}P16i_was_used_for`,
    P17: `${NS}P17_was_motivated_by`,
    P17i: `${NS}P17i_motivated`,
    P19: `${NS}P19_was_intended_use_of`,
    P19i: `${NS}P19i_was_made_for`,
    P20: `${NS}P20_had_specific_purpose`,
    P20i: `${NS}P20i_was_purpose_of`,
    P21: `${NS}P21_had_general_purpose`,
    P21i: `${NS}P21i_was_purpose_of`,
    P22: `${NS}P22_transferred_title_to`,
    P22i: `${NS}P22i_acquired_title_through`,
    P23: `${NS}P23_transferred_title_from`,
    P23i: `${NS}P23i_surrendered_title_through`,
    P24: `${NS}P24_transferred_title_of`,
    P24i: `${NS}P24i_changed_ownership_through`,
    P25: `${NS}P25_moved`,
    P25i: `${NS}P25i_moved_by`,
    P26: `${NS}P26_moved_to`,
    P26i: `${NS}P26i_was_destination_of`,
    P27: `${NS}P27_moved_from`,
    P27i: `${NS}P27i_was_origin_of`,
    P28: `${NS}P28_custody_surrendered_by`,
    P28i: `${NS}P28i_surrendered_custody_through`,
    P29: `${NS}P29_custody_received_by`,
    P29i: `${NS}P29i_received_custody_through`,
    P30: `${NS}P30_transferred_custody_of`,
    P30i: `${NS}P30i_custody_transferred_through`,
    P31: `${NS}P31_has_modified`,
    P31i: `${NS}P31i_was_modified_by`,
    P32: `${NS}P32_used_general_technique`,
    P32i: `${NS}P32i_was_technique_of`,
    P33: `${NS}P33_used_specific_technique`,
    P33i: `${NS}P33i_was_used_by`,
    P34: `${NS}P34_concerned`,
    P34i: `${NS}P34i_was_assessed_by`,
    P35: `${NS}P35_has_identified`,
    P35i: `${NS}P35i_was_identified_by`,
    P37: `${NS}P37_assigned`,
    P37i: `${NS}P37i_was_assigned_by`,
    P38: `${NS}P38_deassigned`,
    P38i: `${NS}P38i_was_deassigned_by`,
    P39: `${NS}P39_measured`,
    P39i: `${NS}P39i_was_measured_by`,
    P40: `${NS}P40_observed_dimension`,
    P40i: `${NS}P40i_was_observed_in`,
    P41: `${NS}P41_classified`,
    P41i: `${NS}P41i_was_classified_by`,
    P42: `${NS}P42_assigned`,
    P42i: `${NS}P42i_was_assigned_by`,
    P43: `${NS}P43_has_dimension`,
    P43i: `${NS}P43i_is_dimension_of`,
    P44: `${NS}P44_has_condition`,
    P44i: `${NS}P44i_condition_of`,
    P45: `${NS}P45_consists_of`,
    P45i: `${NS}P45i_is_incorporated_in`,
    P46: `${NS}P46_is_composed_of`,
    P46i: `${NS}P46i_forms_part_of`,
    P48: `${NS}P48_has_preferred_identifier`,
    P48i: `${NS}P48i_is_preferred_identifier_of`,
    P49: `${NS}P49_has_former_or_current_keeper`,
    P49i: `${NS}P49i_is_former_or_current_keeper_of`,
    P50: `${NS}P50_has_current_keeper`,
    P50i: `${NS}P50i_is_current_keeper_of`,
    P51: `${NS}P51_has_former_or_current_owner`,
    P51i: `${NS}P51i_is_former_or_current_owner_of`,
    P52: `${NS}P52_has_current_owner`,
    P52i: `${NS}P52i_is_current_owner_of`,
    P53: `${NS}P53_has_former_or_current_location`,
    P53i: `${NS}P53i_is_former_or_current_location_of`,
    P54: `${NS}P54_has_current_permanent_location`,
    P54i: `${NS}P54i_is_current_permanent_location_of`,
    P55: `${NS}P55_has_current_location`,
    P55i: `${NS}P55i_currently_holds`,
    P56: `${NS}P56_bears_feature`,
    P56i: `${NS}P56i_is_found_on`,
    P57: `${NS}P57_has_number_of_parts`,
    P58: `${NS}P58_has_section_definition`,
    P58i: `${NS}P58i_defines_section`,
    P59: `${NS}P59_has_section`,
    P59i: `${NS}P59i_is_located_on_or_within`,
    P62: `${NS}P62_depicts`,
    P62i: `${NS}P62i_is_depicted_by`,
    P65: `${NS}P65_shows_visual_item`,
    P65i: `${NS}P65i_is_shown_by`,
    P67: `${NS}P67_refers_to`,
    P67i: `${NS}P67i_is_referred_to_by`,
    P68: `${NS}P68_foresees_use_of`,
    P68i: `${NS}P68i_use_foreseen_by`,
    P69: `${NS}P69_is_associated_with`,
    P70: `${NS}P70_documents`,
    P70i: `${NS}P70i_is_documented_in`,
    P71: `${NS}P71_lists`,
    P71i: `${NS}P71i_is_listed_in`,
    P72: `${NS}P72_has_language`,
    P72i: `${NS}P72i_is_language_of`,
    P73: `${NS}P73_has_translation`,
    P73i: `${NS}P73i_is_translation_of`,
    P74: `${NS}P74_has_current_or_former_residence`,
    P74i: `${NS}P74i_is_current_or_former_residence_of`,
    P75: `${NS}P75_possesses`,
    P75i: `${NS}P75i_is_possessed_by`,
    P76: `${NS}P76_has_contact_point`,
    P76i: `${NS}P76i_provides_access_to`,
    P78: `${NS}P78_is_identified_by`,
    P78i: `${NS}P78i_identifies`,
    P79: `${NS}P79_beginning_is_qualified_by`,
    P80: `${NS}P80_end_is_qualified_by`,
    P81: `${NS}P81_ongoing_throughout`,
    P82: `${NS}P82_at_some_time_within`,
    P83: `${NS}P83_had_at_least_duration`,
    P83i: `${NS}P83i_was_minimum_duration_of`,
    P84: `${NS}P84_had_at_most_duration`,
    P84i: `${NS}P84i_was_maximum_duration_of`,
    P86: `${NS}P86_falls_within`,
    P86i: `${NS}P86i_contains`,
    P87: `${NS}P87_is_identified_by`,
    P87i: `${NS}P87i_identifies`,
    P88: `${NS}P88_consists_of`,
    P88i: `${NS}P88i_forms_part_of`,
    P89: `${NS}P89_falls_within`,
    P89i: `${NS}P89i_contains`,
    P90: `${NS}P90_has_value`,
    P91: `${NS}P91_has_unit`,
    P91i: `${NS}P91i_is_unit_of`,
    P92: `${NS}P92_brought_into_existence`,
    P92i: `${NS}P92i_was_brought_into_existence_by`,
    P93: `${NS}P93_took_out_of_existence`,
    P93i: `${NS}P93i_was_taken_out_of_existence_by`,
    P94: `${NS}P94_has_created`,
    P94i: `${NS}P94i_was_created_by`,
    P95: `${NS}P95_has_formed`,
    P95i: `${NS}P95i_was_formed_by`,
    P96: `${NS}P96_by_mother`,
    P96i: `${NS}P96i_gave_birth`,
    P97: `${NS}P97_from_father`,
    P97i: `${NS}P97i_was_father_for`,
    P98: `${NS}P98_brought_into_life`,
    P98i: `${NS}P98i_was_born`,
    P99: `${NS}P99_dissolved`,
    P99i: `${NS}P99i_was_dissolved_by`,
    P100: `${NS}P100_was_death_of`,
    P100i: `${NS}P100i_died_in`,
    P101: `${NS}P101_had_as_general_use`,
    P101i: `${NS}P101i_was_use_of`,
    P102: `${NS}P102_has_title`,
    P102i: `${NS}P102i_is_title_of`,
    P103: `${NS}P103_was_intended_for`,
    P103i: `${NS}P103i_was_intention_of`,
    P104: `${NS}P104_is_subject_to`,
    P104i: `${NS}P104i_applies_to`,
    P105: `${NS}P105_right_held_by`,
    P105i: `${NS}P105i_has_right_on`,
    P106: `${NS}P106_is_composed_of`,
    P106i: `${NS}P106i_forms_part_of`,
    P107: `${NS}P107_has_current_or_former_member`,
    P107i: `${NS}P107i_is_current_or_former_member_of`,
    P108: `${NS}P108_has_produced`,
    P108i: `${NS}P108i_was_produced_by`,
    P109: `${NS}P109_has_current_or_former_curator`,
    P109i: `${NS}P109i_is_current_or_former_curator_of`,
    P110: `${NS}P110_augmented`,
    P110i: `${NS}P110i_was_augmented_by`,
    P111: `${NS}P111_added`,
    P111i: `${NS}P111i_was_added_by`,
    P112: `${NS}P112_diminished`,
    P112i: `${NS}P112i_was_diminished_by`,
    P113: `${NS}P113_removed`,
    P113i: `${NS}P113i_was_removed_by`,
    P114: `${NS}P114_is_equal_in_time_to`,
    P115: `${NS}P115_finishes`,
    P115i: `${NS}P115i_is_finished_by`,
    P116: `${NS}P116_starts`,
    P116i: `${NS}P116i_is_started_by`,
    P117: `${NS}P117_occurs_during`,
    P117i: `${NS}P117i_includes`,
    P118: `${NS}P118_overlaps_in_time_with`,
    P118i: `${NS}P118i_is_overlapped_in_time_by`,
    P119: `${NS}P119_meets_in_time_with`,
    P119i: `${NS}P119i_is_met_in_time_by`,
    P120: `${NS}P120_occurs_before`,
    P120i: `${NS}P120i_occurs_after`,
    P121: `${NS}P121_overlaps_with`,
    P122: `${NS}P122_borders_with`,
    P123: `${NS}P123_resulted_in`,
    P123i: `${NS}P123i_resulted_from`,
    P124: `${NS}P124_transformed`,
    P124i: `${NS}P124i_was_transformed_by`,
    P125: `${NS}P125_used_object_of_type`,
    P125i: `${NS}P125i_was_type_of_object_used_in`,
    P126: `${NS}P126_employed`,
    P126i: `${NS}P126i_was_employed_in`,
    P127: `${NS}P127_has_broader_term`,
    P127i: `${NS}P127i_has_narrower_term`,
    P128: `${NS}P128_carries`,
    P128i: `${NS}P128i_is_carried_by`,
    P129: `${NS}P129_is_about`,
    P129i: `${NS}P129i_is_subject_of`,
    P130: `${NS}P130_shows_features_of`,
    P130i: `${NS}P130i_features_are_also_found_on`,
    P131: `${NS}P131_is_identified_by`,
    P131i: `${NS}P131i_identifies`,
    P132: `${NS}P132_overlaps_with`,
    P133: `${NS}P133_is_separated_from`,
    P134: `${NS}P134_continued`,
    P134i: `${NS}P134i_was_continued_by`,
    P135: `${NS}P135_created_type`,
    P135i: `${NS}P135i_was_created_by`,
    P136: `${NS}P136_was_based_on`,
    P136i: `${NS}P136i_supported_type_creation`,
    P137: `${NS}P137_exemplifies`,
    P137i: `${NS}P137i_is_exemplified_by`,
    P138: `${NS}P138_represents`,
    P138i: `${NS}P138i_has_representation`,
    P139: `${NS}P139_has_alternative_form`,
    P140: `${NS}P140_assigned_attribute_to`,
    P140i: `${NS}P140i_was_attributed_by`,
    P141: `${NS}P141_assigned`,
    P141i: `${NS}P141i_was_assigned_by`,
    P142: `${NS}P142_used_constituent`,
    P142i: `${NS}P142i_was_used_in`,
    P143: `${NS}P143_joined`,
    P143i: `${NS}P143i_was_joined_by`,
    P144: `${NS}P144_joined_with`,
    P144i: `${NS}P144i_gained_member_by`,
    P145: `${NS}P145_separated`,
    P145i: `${NS}P145i_left_by`,
    P146: `${NS}P146_separated_from`,
    P146i: `${NS}P146i_lost_member_by`,
    P147: `${NS}P147_curated`,
    P147i: `${NS}P147i_was_curated_by`,
    P148: `${NS}P148_has_component`,
    P148i: `${NS}P148i_is_component_of`,
    P149: `${NS}P149_is_identified_by`,
    P149i: `${NS}P149i_identifies`
})