"""
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_CRM 
Summary : Case-sensitive entity & property URI constants (for RDF apps)
Example : 
    from URI_CRM import URI_CRM 
    print(URI_CRM.E1) # "http://www.cidoc-crm.org/cidoc-crm/E1_CRM_Entity"
License : https://mit-license.org
History :
23/02/2023 CFB 
    Extracted from old script, updated to use F-strings,
    updated to reflect CRM v7.1.2 entities and properties
13/03/2025 CFB 
    updated to reflect CRM v7.1.3 entities and properties
    E59 + P196 URIs corrected; E59 added
    Converted to StrEnum class to make immutable values
===============================================================================
"""
from enum import StrEnum

# Namespace
_NS = "http://www.cidoc-crm.org/cidoc-crm/"

# Enum values can't be reassigned so mutable 
class URI_CRM(StrEnum):
    # Entities
    E1 = f"{_NS}E1_CRM_Entity",
    E2 = f"{_NS}E2_Temporal_Entity",
    E3 = f"{_NS}E3_Condition_State",
    E4 = f"{_NS}E4_Period",
    E5 = f"{_NS}E5_Event",
    E6 = f"{_NS}E6_Destruction",
    E7 = f"{_NS}E7_Activity",
    E8 = f"{_NS}E8_Acquisition",
    E9 = f"{_NS}E9_Move",
    E10 = f"{_NS}E10_Transfer_of_Custody",
    E11 = f"{_NS}E11_Modification",
    E12 = f"{_NS}E12_Production",
    E13 = f"{_NS}E13_Attribute_Assignment",
    E14 = f"{_NS}E14_Condition_Assessment",
    E15 = f"{_NS}E15_Identifier_Assignment",
    E16 = f"{_NS}E16_Measurement",
    E17 = f"{_NS}E17_Type_Assignment",
    E18 = f"{_NS}E18_Physical_Thing",
    E19 = f"{_NS}E19_Physical_Object",
    E20 = f"{_NS}E20_Biological_Object",
    E21 = f"{_NS}E21_Person",
    E22 = f"{_NS}E22_Human-Made_Object",
    E24 = f"{_NS}E24_Physical_Human-Made_Thing",
    E25 = f"{_NS}E25_Human-Made_Feature",
    E26 = f"{_NS}E26_Physical_Feature",
    E27 = f"{_NS}E27_Site",
    E28 = f"{_NS}E28_Conceptual_Object",
    E29 = f"{_NS}E29_Design_or_Procedure",
    E30 = f"{_NS}E30_Right",
    E31 = f"{_NS}E31_Document",
    E32 = f"{_NS}E32_Authority_Document",
    E33 = f"{_NS}E33_Linguistic_Object",
    E34 = f"{_NS}E34_Inscription",
    E35 = f"{_NS}E35_Title",
    E36 = f"{_NS}E36_Visual_Item",
    E37 = f"{_NS}E37_Mark",
    E39 = f"{_NS}E39_Actor",
    E41 = f"{_NS}E41_Appellation",
    E42 = f"{_NS}E42_Identifier",
    E52 = f"{_NS}E52_Time-Span",
    E53 = f"{_NS}E53_Place",
    E54 = f"{_NS}E54_Dimension",
    E55 = f"{_NS}E55_Type",
    E56 = f"{_NS}E56_Language",
    E57 = f"{_NS}E57_Material",
    E58 = f"{_NS}E58_Measurement_Unit",
    E59 = f"{_NS}E59_Primitive_Value",
    E60 = f"{_NS}E60_Number",
    E61 = f"{_NS}E61_Time_Primitive",
    E62 = f"{_NS}E62_String",
    E63 = f"{_NS}E63_Beginning_of_Existence",
    E64 = f"{_NS}E64_End_of_Existence",
    E65 = f"{_NS}E65_Creation",
    E66 = f"{_NS}E66_Formation",
    E67 = f"{_NS}E67_Birth",
    E68 = f"{_NS}E68_Dissolution",
    E69 = f"{_NS}E69_Death",
    E70 = f"{_NS}E70_Thing",
    E71 = f"{_NS}E71_Human-Made_Thing",
    E72 = f"{_NS}E72_Legal_Object",
    E73 = f"{_NS}E73_Information_Object",
    E74 = f"{_NS}E74_Group",
    E77 = f"{_NS}E77_Persistent_Item",
    E78 = f"{_NS}E78_Curated_Holding",
    E79 = f"{_NS}E79_Part_Addition",
    E80 = f"{_NS}E80_Part_Removal",
    E81 = f"{_NS}E81_Transformation",
    E83 = f"{_NS}E83_Type_Creation",
    E85 = f"{_NS}E85_Joining",
    E86 = f"{_NS}E86_Leaving",
    E87 = f"{_NS}E87_Curation_Activity",
    E89 = f"{_NS}E89_Propositional_Object",
    E90 = f"{_NS}E90_Symbolic_Object",
    E92 = f"{_NS}E92_Spacetime_Volume",
    E93 = f"{_NS}E93_Presence",
    E95 = f"{_NS}E95_Spacetime_Primitive",
    E96 = f"{_NS}E96_Purchase",
    E97 = f"{_NS}E97_Monetary_Amount",
    E98 = f"{_NS}E98_Currency",
    E99 = f"{_NS}E99_Product_Type",
    # Properties
    P1 = f"{_NS}P1_is_identified_by",
    P1i = f"{_NS}P1i_identifies",
    P2 = f"{_NS}P2_has_type",
    P2i = f"{_NS}P2i_is_type_of",
    P3 = f"{_NS}P3_has_note",
    P4 = f"{_NS}P4_has_time-span",
    P4i = f"{_NS}P4i_is_time-span_of",
    P5 = f"{_NS}P5_consists_of",
    P5i = f"{_NS}P5i_forms_part_of",
    P7 = f"{_NS}P7_took_place_at",
    P7i = f"{_NS}P7i_witnessed",
    P8 = f"{_NS}P8_took_place_on_or_within",
    P8i = f"{_NS}P8i_witnessed",
    P9 = f"{_NS}P9_consists_of",
    P9i = f"{_NS}P9i_forms_part_of",
    P10 = f"{_NS}P10_falls_within",
    P10i = f"{_NS}P10i_contains",
    P11 = f"{_NS}P11_had_participant",
    P11i = f"{_NS}P11i_participated_in",
    P12 = f"{_NS}P12_occurred_in_the_presence_of",
    P12i = f"{_NS}P12i_was_present_at",
    P13 = f"{_NS}P13_destroyed",
    P13i = f"{_NS}P13i_was_destroyed_by",
    P14 = f"{_NS}P14_carried_out_by",
    P14i = f"{_NS}P14i_performed",
    P15 = f"{_NS}P15_was_influenced_by",
    P15i = f"{_NS}P15i_influenced",
    P16 = f"{_NS}P16_used_specific_object",
    P16i = f"{_NS}P16i_was_used_for",
    P17 = f"{_NS}P17_was_motivated_by",
    P17i = f"{_NS}P17i_motivated",
    P19 = f"{_NS}P19_was_intended_use_of",
    P19i = f"{_NS}P19i_was_made_for",
    P20 = f"{_NS}P20_had_specific_purpose",
    P20i = f"{_NS}P20i_was_purpose_of",
    P21 = f"{_NS}P21_had_general_purpose",
    P21i = f"{_NS}P21i_was_purpose_of",
    P22 = f"{_NS}P22_transferred_title_to",
    P22i = f"{_NS}P22i_acquired_title_through",
    P23 = f"{_NS}P23_transferred_title_from",
    P23i = f"{_NS}P23i_surrendered_title_through",
    P24 = f"{_NS}P24_transferred_title_of",
    P24i = f"{_NS}P24i_changed_ownership_through",
    P25 = f"{_NS}P25_moved",
    P25i = f"{_NS}P25i_moved_by",
    P26 = f"{_NS}P26_moved_to",
    P26i = f"{_NS}P26i_was_destination_of",
    P27 = f"{_NS}P27_moved_from",
    P27i = f"{_NS}P27i_was_origin_of",
    P28 = f"{_NS}P28_custody_surrendered_by",
    P28i = f"{_NS}P28i_surrendered_custody_through",
    P29 = f"{_NS}P29_custody_received_by",
    P29i = f"{_NS}P29i_received_custody_through",
    P30 = f"{_NS}P30_transferred_custody_of",
    P30i = f"{_NS}P30i_custody_transferred_through",
    P31 = f"{_NS}P31_has_modified",
    P31i = f"{_NS}P31i_was_modified_by",
    P32 = f"{_NS}P32_used_general_technique",
    P32i = f"{_NS}P32i_was_technique_of",
    P33 = f"{_NS}P33_used_specific_technique",
    P33i = f"{_NS}P33i_was_used_by",
    P34 = f"{_NS}P34_concerned",
    P34i = f"{_NS}P34i_was_assessed_by",
    P35 = f"{_NS}P35_has_identified",
    P35i = f"{_NS}P35i_was_identified_by",
    P37 = f"{_NS}P37_assigned",
    P37i = f"{_NS}P37i_was_assigned_by",
    P38 = f"{_NS}P38_deassigned",
    P38i = f"{_NS}P38i_was_deassigned_by",
    P39 = f"{_NS}P39_measured",
    P39i = f"{_NS}P39i_was_measured_by",
    P40 = f"{_NS}P40_observed_dimension",
    P40i = f"{_NS}P40i_was_observed_in",
    P41 = f"{_NS}P41_classified",
    P41i = f"{_NS}P41i_was_classified_by",
    P42 = f"{_NS}P42_assigned",
    P42i = f"{_NS}P42i_was_assigned_by",
    P43 = f"{_NS}P43_has_dimension",
    P43i = f"{_NS}P43i_is_dimension_of",
    P44 = f"{_NS}P44_has_condition",
    P44i = f"{_NS}P44i_is_condition_of",
    P45 = f"{_NS}P45_consists_of",
    P45i = f"{_NS}P45i_is_incorporated_in",
    P46 = f"{_NS}P46_is_composed_of",
    P46i = f"{_NS}P46i_forms_part_of",
    P48 = f"{_NS}P48_has_preferred_identifier",
    P48i = f"{_NS}P48i_is_preferred_identifier_of",
    P49 = f"{_NS}P49_has_former_or_current_keeper",
    P49i = f"{_NS}P49i_is_former_or_current_keeper_of",
    P50 = f"{_NS}P50_has_current_keeper",
    P50i = f"{_NS}P50i_is_current_keeper_of",
    P51 = f"{_NS}P51_has_former_or_current_owner",
    P51i = f"{_NS}P51i_is_former_or_current_owner_of",
    P52 = f"{_NS}P52_has_current_owner",
    P52i = f"{_NS}P52i_is_current_owner_of",
    P53 = f"{_NS}P53_has_former_or_current_location",
    P53i = f"{_NS}P53i_is_former_or_current_location_of",
    P54 = f"{_NS}P54_has_current_permanent_location",
    P54i = f"{_NS}P54i_is_current_permanent_location_of",
    P55 = f"{_NS}P55_has_current_location",
    P55i = f"{_NS}P55i_currently_holds",
    P56 = f"{_NS}P56_bears_feature",
    P56i = f"{_NS}P56i_is_found_on",
    P57 = f"{_NS}P57_has_number_of_parts",
    P59 = f"{_NS}P59_has_section",
    P59i = f"{_NS}P59i_is_located_on_or_within",
    P62 = f"{_NS}P62_depicts",
    P62i = f"{_NS}P62i_is_depicted_by",
    P65 = f"{_NS}P65_shows_visual_item",
    P65i = f"{_NS}P65i_is_shown_by",
    P67 = f"{_NS}P67_refers_to",
    P67i = f"{_NS}P67i_is_referred_to_by",
    P68 = f"{_NS}P68_foresees_use_of",
    P68i = f"{_NS}P68i_use_foreseen_by",
    P69 = f"{_NS}P69_has_association_with",
    P69i = f"{_NS}P69i_is_associated_with",
    P70 = f"{_NS}P70_documents",
    P70i = f"{_NS}P70i_is_documented_in",
    P71 = f"{_NS}P71_lists",
    P71i = f"{_NS}P71i_is_listed_in",
    P72 = f"{_NS}P72_has_language",
    P72i = f"{_NS}P72i_is_language_of",
    P73 = f"{_NS}P73_has_translation",
    P73i = f"{_NS}P73i_is_translation_of",
    P74 = f"{_NS}P74_has_current_or_former_residence",
    P74i = f"{_NS}P74i_is_current_or_former_residence_of",
    P75 = f"{_NS}P75_possesses",
    P75i = f"{_NS}P75i_is_possessed_by",
    P76 = f"{_NS}P76_has_contact_point",
    P76i = f"{_NS}P76i_provides_access_to",
    P79 = f"{_NS}P79_beginning_is_qualified_by",
    P80 = f"{_NS}P80_end_is_qualified_by",
    P81 = f"{_NS}P81_ongoing_throughout",
    P82 = f"{_NS}P82_at_some_time_within",
    P86 = f"{_NS}P86_falls_within",
    P86i = f"{_NS}P86i_contains",
    P89 = f"{_NS}P89_falls_within",
    P89i = f"{_NS}P89i_contains",
    P90 = f"{_NS}P90_has_value",
    P91 = f"{_NS}P91_has_unit",
    P91i = f"{_NS}P91i_is_unit_of",
    P92 = f"{_NS}P92_brought_into_existence",
    P92i = f"{_NS}P92i_was_brought_into_existence_by",
    P93 = f"{_NS}P93_took_out_of_existence",
    P93i = f"{_NS}P93i_was_taken_out_of_existence_by",
    P94 = f"{_NS}P94_has_created",
    P94i = f"{_NS}P94i_was_created_by",
    P95 = f"{_NS}P95_has_formed",
    P95i = f"{_NS}P95i_was_formed_by",
    P96 = f"{_NS}P96_by_mother",
    P96i = f"{_NS}P96i_gave_birth",
    P97 = f"{_NS}P97_from_father",
    P97i = f"{_NS}P97i_was_father_for",
    P98 = f"{_NS}P98_brought_into_life",
    P98i = f"{_NS}P98i_was_born",
    P99 = f"{_NS}P99_dissolved",
    P99i = f"{_NS}P99i_was_dissolved_by",
    P100 = f"{_NS}P100_was_death_of",
    P100i = f"{_NS}P100i_died_in",
    P101 = f"{_NS}P101_had_as_general_use",
    P101i = f"{_NS}P101i_was_use_of",
    P102 = f"{_NS}P102_has_title",
    P102i = f"{_NS}P102i_is_title_of",
    P103 = f"{_NS}P103_was_intended_for",
    P103i = f"{_NS}P103i_was_intention_of",
    P104 = f"{_NS}P104_is_subject_to",
    P104i = f"{_NS}P104i_applies_to",
    P105 = f"{_NS}P105_right_held_by",
    P105i = f"{_NS}P105i_has_right_on",
    P106 = f"{_NS}P106_is_composed_of",
    P106i = f"{_NS}P106i_forms_part_of",
    P107 = f"{_NS}P107_has_current_or_former_member",
    P107i = f"{_NS}P107i_is_current_or_former_member_of",
    P108 = f"{_NS}P108_has_produced",
    P108i = f"{_NS}P108i_was_produced_by",
    P109 = f"{_NS}P109_has_current_or_former_curator",
    P109i = f"{_NS}P109i_is_current_or_former_curator_of",
    P110 = f"{_NS}P110_augmented",
    P110i = f"{_NS}P110i_was_augmented_by",
    P111 = f"{_NS}P111_added",
    P111i = f"{_NS}P111i_was_added_by",
    P112 = f"{_NS}P112_diminished",
    P112i = f"{_NS}P112i_was_diminished_by",
    P113 = f"{_NS}P113_removed",
    P113i = f"{_NS}P113i_was_removed_by",
    P121 = f"{_NS}P121_overlaps_with",
    P122 = f"{_NS}P122_borders_with",
    P123 = f"{_NS}P123_resulted_in",
    P123i = f"{_NS}P123i_resulted_from",
    P124 = f"{_NS}P124_transformed",
    P124i = f"{_NS}P124i_was_transformed_by",
    P125 = f"{_NS}P125_used_object_of_type",
    P125i = f"{_NS}P125i_was_type_of_object_used_in",
    P126 = f"{_NS}P126_employed",
    P126i = f"{_NS}P126i_was_employed_in",
    P127 = f"{_NS}P127_has_broader_term",
    P127i = f"{_NS}P127i_has_narrower_term",
    P128 = f"{_NS}P128_carries",
    P128i = f"{_NS}P128i_is_carried_by",
    P129 = f"{_NS}P129_is_about",
    P129i = f"{_NS}P129i_is_subject_of",
    P130 = f"{_NS}P130_shows_features_of",
    P130i = f"{_NS}P130i_features_are_also_found_on",
    P132 = f"{_NS}P132_spatiotemporally_overlaps_with",
    P133 = f"{_NS}P133_is_spatiotemporally_separated_from",
    P134 = f"{_NS}P134_continued",
    P134i = f"{_NS}P134i_was_continued_by",
    P135 = f"{_NS}P135_created_type",
    P135i = f"{_NS}P135i_was_created_by",
    P136 = f"{_NS}P136_was_based_on",
    P136i = f"{_NS}P136i_supported_type_creation",
    P137 = f"{_NS}P137_exemplifies",
    P137i = f"{_NS}P137i_is_exemplified_by",
    P138 = f"{_NS}P138_represents",
    P138i = f"{_NS}P138i_has_representation",
    P139 = f"{_NS}P139_has_alternative_form",
    P139i = f"{_NS}P139i_is_alternative_form_of",
    P140 = f"{_NS}P140_assigned_attribute_to",
    P140i = f"{_NS}P140i_was_attributed_by",
    P141 = f"{_NS}P141_assigned",
    P141i = f"{_NS}P141i_was_assigned_by",
    P142 = f"{_NS}P142_used_constituent",
    P142i = f"{_NS}P142i_was_used_in",
    P143 = f"{_NS}P143_joined",
    P143i = f"{_NS}P143i_was_joined_by",
    P144 = f"{_NS}P144_joined_with",
    P144i = f"{_NS}P144i_gained_member_by",
    P145 = f"{_NS}P145_separated",
    P145i = f"{_NS}P145i_left_by",
    P146 = f"{_NS}P146_separated_from",
    P146i = f"{_NS}P146i_lost_member_by",
    P147 = f"{_NS}P147_curated",
    P147i = f"{_NS}P147i_was_curated_by",
    P148 = f"{_NS}P148_has_component",
    P148i = f"{_NS}P148i_is_component_of",
    P150 = f"{_NS}P150_defines_typical_parts_of",
    P150i = f"{_NS}P150i_defines_typical_wholes_for",
    P151 = f"{_NS}P151_was_formed_from",
    P151i = f"{_NS}P151i_participated_in",
    P152 = f"{_NS}P152_has_parent",
    P152i = f"{_NS}P152i_is_parent_of",
    P156 = f"{_NS}P156_occupies",
    P156i = f"{_NS}P156i_is_occupied_by",
    P157 = f"{_NS}P157_is_at_rest_relative_to",
    P157i = f"{_NS}P157i_provides_reference_space_for",
    P160 = f"{_NS}P160_has_temporal_projection",
    P160i = f"{_NS}P160i_is_temporal_projection_of",
    P161 = f"{_NS}P161_has_spatial_projection",
    P161i = f"{_NS}P161i_is_spatial_projection_of",
    P164 = f"{_NS}P164_is_temporally_specified_by",
    P164i = f"{_NS}P164i_temporally_specifies",
    P165 = f"{_NS}P165_incorporates",
    P165i = f"{_NS}P165i_is_incorporated_in",
    P166 = f"{_NS}P166_was_a_presence_of",
    P166i = f"{_NS}P166i_had_presence",
    P167 = f"{_NS}P167_was_within",
    P167i = f"{_NS}P167i_includes",
    P168 = f"{_NS}P168_place_is_defined_by",
    P168i = f"{_NS}P168i_defines_place",
    P169 = f"{_NS}P169_defines_spacetime_volume",
    P169i = f"{_NS}P169i_spacetime_volume_is_defined_by",
    P170 = f"{_NS}P170_defines_time",
    P170i = f"{_NS}P170i_time_is_defined_by",
    P171 = f"{_NS}P171_at_some_place_within",
    P172 = f"{_NS}P172_contains",
    P173 = f"{_NS}P170_starts_before_or_with_the_end_of",
    P173i = f"{_NS}P170i_ends_after_or_with_the_start_of",
    P174 = f"{_NS}P174_starts_before_the_end_of",
    P174i = f"{_NS}P174i_ends_after_the_start_of",
    P175 = f"{_NS}P175_starts_before_or_with_the_start_of",
    P175i = f"{_NS}P175i_starts_after_or_with_the_start_of",
    P176 = f"{_NS}P176_starts_before_the_start_of",
    P176i = f"{_NS}P176i_starts_after_the_start_of",
    P177 = f"{_NS}P177_assigned_property_of_type",
    P177i = f"{_NS}P177i_is_type_of_property_assigned",
    P179 = f"{_NS}P179_had_sales_price",
    P179i = f"{_NS}P179i_was_sales_price_of",
    P180 = f"{_NS}P180_has_currency",
    P180i = f"{_NS}P180i_was_currency_of",
    P182 = f"{_NS}P182_ends_before_or_with_the_start_of",
    P182i = f"{_NS}P182i_starts_after_or_with_the_end_of",
    P183 = f"{_NS}P183_ends_before_the_start_of",
    P183i = f"{_NS}P183i_starts_after_the_end_of",
    P184 = f"{_NS}P184_ends_before_or_with_the_end_of",
    P184i = f"{_NS}P184i_ends_with_or_after_the_end_of",
    P185 = f"{_NS}P185_ends_before_the_end_of",
    P185i = f"{_NS}P185i_ends_after_the_end_of",
    P186 = f"{_NS}P186_produced_thing_of_product_type",
    P186i = f"{_NS}P186i_is_produced_by",
    P187 = f"{_NS}P187_has_production_plan",
    P187i = f"{_NS}P187i_is_production_plan_for",
    P188 = f"{_NS}P188_requires_production_tool",
    P188i = f"{_NS}P188i_is_production_tool_for",
    P189 = f"{_NS}P189_approximates",
    P189i = f"{_NS}P189i_is_approximated_by",
    P190 = f"{_NS}P190_has_symbolic_content",
    P191 = f"{_NS}P191_had_duration",
    P191i = f"{_NS}P191i_was_duration_of",
    P195 = f"{_NS}P195_was_a_presence_of",
    P195i = f"{_NS}P195i_had_presence",
    P196 = f"{_NS}P196_defines",
    P196i = f"{_NS}P196i_is_defined_by",
    P197 = f"{_NS}P197_covered_parts_of",
    P197i = f"{_NS}P197i_was_partially_covered_by",
    P198 = f"{_NS}P198_holds_or_supports",
    P198i = f"{_NS}P198i_is_held_or_supported_by"

# test the CRM class
if __name__ == "__main__":
    print(URI_CRM.E1)
    print(URI_CRM.E2)  
    print(URI_CRM.E1 == "http://www.cidoc-crm.org/cidoc-crm/E1_CRM_Entity")
    print(URI_CRM.E1 == URI_CRM.E1)
    print(URI_CRM.E1 == URI_CRM.E2)
    #try to reassign (error)
    URI_CRM.E1 = URI_CRM.E2   