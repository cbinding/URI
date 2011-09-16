#ifndef _URI_CRM42_H 
#define _URI_CRM42_H 

#define NS_CRM42 "http://cidoc.ics.forth.gr/rdfs/cidoc_crm_v4.2.rdfs#"    
      
namespace URI
{
	// usage: URI::RDF::TYPE, URI::RDF::VALUE etc.	
   namespace CRM42
   {  
    // Entity types
    static const char E1[] = NS_CRM42 "E1.CRM_Entity";
	static const char E2[] = NS_CRM42 "E2.Temporal_Entity";
	static const char E3[] = NS_CRM42 "E3.Condition_State";
	static const char E4[] = NS_CRM42 "E4.Period";
	static const char E5[] = NS_CRM42 "E5.Event";
	static const char E6[] = NS_CRM42 "E6.Destruction";
	static const char E7[] = NS_CRM42 "E7.Activity";
	static const char E8[] = NS_CRM42 "E8.Acquisition";
	static const char E9[] = NS_CRM42 "E9.Move";
	static const char E10[] = NS_CRM42 "E10.Transfer_of_Custody";
	static const char E11[] = NS_CRM42 "E11.Modification";
	static const char E12[] = NS_CRM42 "E12.Production";
	static const char E13[] = NS_CRM42 "E13.Attribute_Assignment";
	static const char E14[] = NS_CRM42 "E14.Condition_Assessment";
	static const char E15[] = NS_CRM42 "E15.Identifier_Assignment";
	static const char E16[] = NS_CRM42 "E16.Measurement";
	static const char E17[] = NS_CRM42 "E17.Type_Assignment";
	static const char E18[] = NS_CRM42 "E18.Physical_Thing";
	static const char E19[] = NS_CRM42 "E19.Physical_Object";
	static const char E20[] = NS_CRM42 "E20.Biological_Object";
	static const char E21[] = NS_CRM42 "E21.Person";
	static const char E22[] = NS_CRM42 "E22.Man-Made_Object";
	static const char E24[] = NS_CRM42 "E24.Physical_Man-Made_Thing";
	static const char E25[] = NS_CRM42 "E25.Man-Made_Feature";
	static const char E26[] = NS_CRM42 "E26.Physical_Feature";
	static const char E27[] = NS_CRM42 "E27.Site";
	static const char E28[] = NS_CRM42 "E28.Conceptual_Object";
	static const char E29[] = NS_CRM42 "E29.Design_or_Procedure";
	static const char E30[] = NS_CRM42 "E30.Right";
	static const char E31[] = NS_CRM42 "E31.Document";
	static const char E32[] = NS_CRM42 "E32.Authority_Document";
	static const char E33[] = NS_CRM42 "E33.Linguistic_Object";
	static const char E34[] = NS_CRM42 "E34.Inscription";
	static const char E35[] = NS_CRM42 "E35.Title";
	static const char E36[] = NS_CRM42 "E36.Visual_Item";
	static const char E37[] = NS_CRM42 "E37.Mark";
	static const char E38[] = NS_CRM42 "E38.Image";
	static const char E39[] = NS_CRM42 "E39.Actor";
	static const char E40[] = NS_CRM42 "E40.Legal_Body";
	static const char E41[] = NS_CRM42 "E41.Appellation";
	static const char E42[] = NS_CRM42 "E42.Object_Identifier";
	static const char E44[] = NS_CRM42 "E44.Place_Appellation";
	static const char E45[] = NS_CRM42 "E45.Address";
	static const char E46[] = NS_CRM42 "E46.Section_Definition";
	static const char E47[] = NS_CRM42 "E47.Spatial_Coordinates";
	static const char E48[] = NS_CRM42 "E48.Place_Name";
	static const char E49[] = NS_CRM42 "E49.Time_Appellation";
	static const char E50[] = NS_CRM42 "E50.Date";
	static const char E51[] = NS_CRM42 "E51.Contact_Point";
	static const char E52[] = NS_CRM42 "E52.Time-Span";
	static const char E53[] = NS_CRM42 "E53.Place";
	static const char E54[] = NS_CRM42 "E54.Dimension";
	static const char E55[] = NS_CRM42 "E55.Type";
	static const char E56[] = NS_CRM42 "E56.Language";
	static const char E57[] = NS_CRM42 "E57.Material";
	static const char E58[] = NS_CRM42 "E58.Measurement_Unit";
	static const char E59[] = NS_CRM42 "E59.Primitive_Value";
	static const char E60[] = NS_CRM42 "E60.Number";
	static const char E61[] = NS_CRM42 "E61.Time_Primitive";
	static const char E62[] = NS_CRM42 "E62.String";
	static const char E63[] = NS_CRM42 "E63.Beginning_of_Existence";
	static const char E64[] = NS_CRM42 "E64.End_of_Existence";
	static const char E65[] = NS_CRM42 "E65.Creation";
	static const char E66[] = NS_CRM42 "E66.Formation";
	static const char E67[] = NS_CRM42 "E67.Birth";
	static const char E68[] = NS_CRM42 "E68.Dissolution";
	static const char E69[] = NS_CRM42 "E69.Death";
	static const char E70[] = NS_CRM42 "E70.Thing";
	static const char E71[] = NS_CRM42 "E71.Man-Made_Thing";
	static const char E72[] = NS_CRM42 "E72.Legal_Object";
	static const char E73[] = NS_CRM42 "E73.Information_Object";
	static const char E74[] = NS_CRM42 "E74.Group";
	static const char E75[] = NS_CRM42 "E75.Conceptual_Object_Appellation";
	static const char E77[] = NS_CRM42 "E77.Persistent_Item";
	static const char E78[] = NS_CRM42 "E78.Collection";
	static const char E79[] = NS_CRM42 "E79.Part_Addition";
	static const char E80[] = NS_CRM42 "E80.Part_Removal";
	static const char E81[] = NS_CRM42 "E81.Transformation";
	static const char E82[] = NS_CRM42 "E82.Actor_Appellation";
	static const char E83[] = NS_CRM42 "E83.Type_Creation";
	static const char E84[] = NS_CRM42 "E84.Information_Carrier";
	// Property types
	static const char P1F[] = NS_CRM42 "P1F.is_identified_by";
	static const char P1B[] = NS_CRM42 "P1B.identifies";
	static const char P2F[] = NS_CRM42 "P2F.has_type";
	static const char P2B[] = NS_CRM42 "P2B.is_type_of";
	static const char P3F[] = NS_CRM42 "P3F.has_note";
	static const char P4F[] = NS_CRM42 "P4F.has_time-span";
	static const char P4B[] = NS_CRM42 "P4B.is_time-span_of";
	static const char P5F[] = NS_CRM42 "P5F.consists_of";
	static const char P5B[] = NS_CRM42 "P5B.forms_part_of";
	static const char P7F[] = NS_CRM42 "P7F.took_place_at";
	static const char P7B[] = NS_CRM42 "P7B.witnessed";
	static const char P8F[] = NS_CRM42 "P8F.took_place_on_or_within";
	static const char P8B[] = NS_CRM42 "P8B.witnessed";
	static const char P9F[] = NS_CRM42 "P9F.consists_of";
	static const char P9B[] = NS_CRM42 "P9B.forms_part_of";
	static const char P10F[] = NS_CRM42 "P10F.falls_within";
	static const char P10B[] = NS_CRM42 "P10B.contains";
	static const char P11F[] = NS_CRM42 "P11F.had_participant";
	static const char P11B[] = NS_CRM42 "P11B.participated_in";
	static const char P12F[] = NS_CRM42 "P12F.occurred_in_the_presence_of";
	static const char P12B[] = NS_CRM42 "P12B.was_present_at";
	static const char P13F[] = NS_CRM42 "P13F.destroyed";
	static const char P13B[] = NS_CRM42 "P13B.was_destroyed_by";
	static const char P14F[] = NS_CRM42 "P14F.carried_out_by";
	static const char P14B[] = NS_CRM42 "P14B.performed";
	static const char P15F[] = NS_CRM42 "P15F.was_influenced_by";
	static const char P15B[] = NS_CRM42 "P15B.influenced";
	static const char P16F[] = NS_CRM42 "P16F.used_specific_object";
	static const char P16B[] = NS_CRM42 "P16B.was_used_for";
	static const char P17F[] = NS_CRM42 "P17F.was_motivated_by";
	static const char P17B[] = NS_CRM42 "P17B.motivated";
	static const char P19F[] = NS_CRM42 "P19F.was_intended_use_of";
	static const char P19B[] = NS_CRM42 "P19B.was_made_for";
	static const char P20F[] = NS_CRM42 "P20F.had_specific_purpose";
	static const char P20B[] = NS_CRM42 "P20B.was_purpose_of";
	static const char P21F[] = NS_CRM42 "P21F.had_general_purpose";
	static const char P21B[] = NS_CRM42 "P21B.was_purpose_of";
	static const char P22F[] = NS_CRM42 "P22F.transferred_title_to";
	static const char P22B[] = NS_CRM42 "P22B.acquired_title_through";
	static const char P23F[] = NS_CRM42 "P23F.transferred_title_from";
	static const char P23B[] = NS_CRM42 "P23B.surrendered_title_through";
	static const char P24F[] = NS_CRM42 "P24F.transferred_title_of";
	static const char P24B[] = NS_CRM42 "P24B.changed_ownership_through";
	static const char P25F[] = NS_CRM42 "P25F.moved";
	static const char P25B[] = NS_CRM42 "P25B.moved_by";
	static const char P26F[] = NS_CRM42 "P26F.moved_to";
	static const char P26B[] = NS_CRM42 "P26B.was_destination_of";
	static const char P27F[] = NS_CRM42 "P27F.moved_from";
	static const char P27B[] = NS_CRM42 "P27B.was_origin_of";
	static const char P28F[] = NS_CRM42 "P28F.custody_surrendered_by";
	static const char P28B[] = NS_CRM42 "P28B.surrendered_custody_through";
	static const char P29F[] = NS_CRM42 "P29F.custody_received_by";
	static const char P29B[] = NS_CRM42 "P29B.received_custody_through";
	static const char P30F[] = NS_CRM42 "P30F.transferred_custody_of";
	static const char P30B[] = NS_CRM42 "P30B.custody_transferred_through";
	static const char P31F[] = NS_CRM42 "P31F.has_modified";
	static const char P31B[] = NS_CRM42 "P31B.was_modified_by";
	static const char P32F[] = NS_CRM42 "P32F.used_general_technique";
	static const char P32B[] = NS_CRM42 "P32B.was_technique_of";
	static const char P33F[] = NS_CRM42 "P33F.used_specific_technique";
	static const char P33B[] = NS_CRM42 "P33B.was_used_by";
	static const char P34F[] = NS_CRM42 "P34F.concerned";
	static const char P34B[] = NS_CRM42 "P34B.was_assessed_by";
	static const char P35F[] = NS_CRM42 "P35F.has_identified";
	static const char P35B[] = NS_CRM42 "P35B.identified_by";
	static const char P36F[] = NS_CRM42 "P36F.registered";
	static const char P36B[] = NS_CRM42 "P36B.was_registered_by";
	static const char P37F[] = NS_CRM42 "P37F.assigned";
	static const char P37B[] = NS_CRM42 "P37B.was_assigned_by";
	static const char P38F[] = NS_CRM42 "P38F.deassigned";
	static const char P38B[] = NS_CRM42 "P38B.was_deassigned_by";
	static const char P39F[] = NS_CRM42 "P39F.measured";
	static const char P39B[] = NS_CRM42 "P39B.was_measured_by";
	static const char P40F[] = NS_CRM42 "P40F.observed_dimension";
	static const char P40B[] = NS_CRM42 "P40B.was_observed_in";
	static const char P41F[] = NS_CRM42 "P41F.classified";
	static const char P41B[] = NS_CRM42 "P41B.was_classified_by";
	static const char P42F[] = NS_CRM42 "P42F.assigned";
	static const char P42B[] = NS_CRM42 "P42B.was_assigned_by";
	static const char P43F[] = NS_CRM42 "P43F.has_dimension";
	static const char P43B[] = NS_CRM42 "P43B.is_dimension_of";
	static const char P44F[] = NS_CRM42 "P44F.has_condition";
	static const char P44B[] = NS_CRM42 "P44B.is_condition_of";
	static const char P45F[] = NS_CRM42 "P45F.consists_of";
	static const char P45B[] = NS_CRM42 "P45B.is_incorporated_in";
	static const char P46F[] = NS_CRM42 "P46F.is_composed_of";
	static const char P46B[] = NS_CRM42 "P46B.forms_part_of";
	static const char P47F[] = NS_CRM42 "P47F.is_identified_by";
	static const char P47B[] = NS_CRM42 "P47B.identifies";
	static const char P48F[] = NS_CRM42 "P48F.has_preferred_identifier";
	static const char P48B[] = NS_CRM42 "P48B.is_preferred_identifier_of";
	static const char P49F[] = NS_CRM42 "P49F.has_former_or_current_keeper";
	static const char P49B[] = NS_CRM42 "P49B.is_former_or_current_keeper_of";
	static const char P50F[] = NS_CRM42 "P50F.has_current_keeper";
	static const char P50B[] = NS_CRM42 "P50B.is_current_keeper_of";
	static const char P51F[] = NS_CRM42 "P51F.has_former_or_current_owner";
	static const char P51B[] = NS_CRM42 "P51B.is_former_or_current_owner_of";
	static const char P52F[] = NS_CRM42 "P52F.has_current_owner";
	static const char P52B[] = NS_CRM42 "P52B.is_current_owner_of";
	static const char P53F[] = NS_CRM42 "P53F.has_former_or_current_location";
	static const char P53B[] = NS_CRM42 "P53B.is_former_or_current_location_of";
	static const char P54F[] = NS_CRM42 "P54F.has_current_permanent_location";
	static const char P54B[] = NS_CRM42 "P54B.is_current_permanent_location_of";
	static const char P55F[] = NS_CRM42 "P55F.has_current_location";
	static const char P55B[] = NS_CRM42 "P55B.currently_holds";
	static const char P56F[] = NS_CRM42 "P56F.bears_feature";
	static const char P56B[] = NS_CRM42 "P56B.is_found_on";
	static const char P57F[] = NS_CRM42 "P57F.has_number_of_parts";
	static const char P58F[] = NS_CRM42 "P58F.has_section_definition";
	static const char P58B[] = NS_CRM42 "P58B.defines_section";
	static const char P59F[] = NS_CRM42 "P59F.has_section";
	static const char P59B[] = NS_CRM42 "P59B.is_located_on_or_within";
	static const char P62F[] = NS_CRM42 "P62F.depicts";
	static const char P62B[] = NS_CRM42 "P62B.is_depicted_by";
	static const char P65F[] = NS_CRM42 "P65F.shows_visual_item";
	static const char P65B[] = NS_CRM42 "P65B.is_shown_by";
	static const char P67F[] = NS_CRM42 "P67F.refers_to";
	static const char P67B[] = NS_CRM42 "P67B.is_referred_to_by";
	static const char P68F[] = NS_CRM42 "P68F.usually_employs";
	static const char P68B[] = NS_CRM42 "P68B.is_usually_employed_by";
	static const char P69F[] = NS_CRM42 "P69F.is_associated_with";
	static const char P70F[] = NS_CRM42 "P70F.documents";
	static const char P70B[] = NS_CRM42 "P70B.is_documented_in";
	static const char P71F[] = NS_CRM42 "P71F.lists";
	static const char P71B[] = NS_CRM42 "P71B.is_listed_in";
	static const char P72F[] = NS_CRM42 "P72F.has_language";
	static const char P72B[] = NS_CRM42 "P72B.is_language_of";
	static const char P73F[] = NS_CRM42 "P73F.has_translation";
	static const char P73B[] = NS_CRM42 "P73B.is_translation_of";
	static const char P74F[] = NS_CRM42 "P74F.has_current_or_former_residence";
	static const char P74B[] = NS_CRM42 "P74B.is_current_or_former_residence_of";
	static const char P75F[] = NS_CRM42 "P75F.possesses";
	static const char P75B[] = NS_CRM42 "P75B.is_possessed_by";
	static const char P76F[] = NS_CRM42 "P76F.has_contact_point";
	static const char P76B[] = NS_CRM42 "P76B.provides_access_to";
	static const char P78F[] = NS_CRM42 "P78F.is_identified_by";
	static const char P78B[] = NS_CRM42 "P78B.identifies";
	static const char P79F[] = NS_CRM42 "P79F.beginning_is_qualified_by";
	static const char P80F[] = NS_CRM42 "P80F.end_is_qualified_by";
	static const char P81F[] = NS_CRM42 "P81F.ongoing_throughout";
	static const char P82F[] = NS_CRM42 "P82F.at_some_time_within";
	static const char P83F[] = NS_CRM42 "P83F.had_at_least_duration";
	static const char P83B[] = NS_CRM42 "P83B.was_minimum_duration_of";
	static const char P84F[] = NS_CRM42 "P84F.had_at_most_duration";
	static const char P84B[] = NS_CRM42 "P84B.was_maximum_duration_of";
	static const char P86F[] = NS_CRM42 "P86F.falls_within";
	static const char P86B[] = NS_CRM42 "P86B.contains";
	static const char P87F[] = NS_CRM42 "P87F.is_identified_by";
	static const char P87B[] = NS_CRM42 "P87B.identifies";
	static const char P88F[] = NS_CRM42 "P88F.consists_of";
	static const char P88B[] = NS_CRM42 "P88B.forms_part_of";
	static const char P89F[] = NS_CRM42 "P89F.falls_within";
	static const char P89B[] = NS_CRM42 "P89B.contains";
	static const char P90F[] = NS_CRM42 "P90F.has_value";
	static const char P91F[] = NS_CRM42 "P91F.has_unit";
	static const char P91B[] = NS_CRM42 "P91B.is_unit_of";
	static const char P92F[] = NS_CRM42 "P92F.brought_into_existence";
	static const char P92B[] = NS_CRM42 "P92B.was_brought_into_existence_by";
	static const char P93F[] = NS_CRM42 "P93F.took_out_of_existence";
	static const char P93B[] = NS_CRM42 "P93B.was_taken_out_of_existence_by";
	static const char P94F[] = NS_CRM42 "P94F.has_created";
	static const char P94B[] = NS_CRM42 "P94B.was_created_by";
	static const char P95F[] = NS_CRM42 "P95F.has_formed";
	static const char P95B[] = NS_CRM42 "P95B.was_formed_by";
	static const char P96F[] = NS_CRM42 "P96F.by_mother";
	static const char P96B[] = NS_CRM42 "P96B.gave_birth";
	static const char P97F[] = NS_CRM42 "P97F.from_father";
	static const char P97B[] = NS_CRM42 "P97B.was_father_for";
	static const char P98F[] = NS_CRM42 "P98F.brought_into_life";
	static const char P98B[] = NS_CRM42 "P98B.was_born";
	static const char P99F[] = NS_CRM42 "P99F.dissolved";
	static const char P99B[] = NS_CRM42 "P99B.was_dissolved_by";
	static const char P100F[] = NS_CRM42 "P100F.was_death_of";
	static const char P100B[] = NS_CRM42 "P100B.died_in";
	static const char P101F[] = NS_CRM42 "P101F.had_as_general_use";
	static const char P101B[] = NS_CRM42 "P101B.was_use_of";
	static const char P102F[] = NS_CRM42 "P102F.has_title";
	static const char P102B[] = NS_CRM42 "P102B.is_title_of";
	static const char P103F[] = NS_CRM42 "P103F.was_intended_for";
	static const char P103B[] = NS_CRM42 "P103B.was_intention_of";
	static const char P104F[] = NS_CRM42 "P104F.is_subject_to";
	static const char P104B[] = NS_CRM42 "P104B.applies_to";
	static const char P105F[] = NS_CRM42 "P105F.right_held_by";
	static const char P105B[] = NS_CRM42 "P105B.has_right_on";
	static const char P106F[] = NS_CRM42 "P106F.is_composed_of";
	static const char P106B[] = NS_CRM42 "P106B.forms_part_of";
	static const char P107F[] = NS_CRM42 "P107F.has_current_or_former_member";
	static const char P107B[] = NS_CRM42 "P107B.is_current_or_former_member_of";
	static const char P108F[] = NS_CRM42 "P108F.has_produced";
	static const char P108B[] = NS_CRM42 "P108B.was_produced_by";
	static const char P109F[] = NS_CRM42 "P109F.has_current_or_former_curator";
	static const char P109B[] = NS_CRM42 "P109B.is_current_or_former_curator_of";
	static const char P110F[] = NS_CRM42 "P110F.augmented";
	static const char P110B[] = NS_CRM42 "P110B.was_augmented_by";
	static const char P111F[] = NS_CRM42 "P111F.added";
	static const char P111B[] = NS_CRM42 "P111B.was_added_by";
	static const char P112F[] = NS_CRM42 "P112F.diminished";
	static const char P112B[] = NS_CRM42 "P112B.was_diminished_by";
	static const char P113F[] = NS_CRM42 "P113F.removed";
	static const char P113B[] = NS_CRM42 "P113B.was_removed_by";
	static const char P114F[] = NS_CRM42 "P114F.is_equal_in_time_to";
	static const char P115F[] = NS_CRM42 "P115F.finishes";
	static const char P115B[] = NS_CRM42 "P115B.is_finished_by";
	static const char P116F[] = NS_CRM42 "P116F.starts";
	static const char P116B[] = NS_CRM42 "P116B.is_started_by";
	static const char P117F[] = NS_CRM42 "P117F.occurs_during";
	static const char P117B[] = NS_CRM42 "P117B.includes";
	static const char P118F[] = NS_CRM42 "P118F.overlaps_in_time_with";
	static const char P118B[] = NS_CRM42 "P118B.is_overlapped_in_time_by";
	static const char P119F[] = NS_CRM42 "P119F.meets_in_time_with";
	static const char P119B[] = NS_CRM42 "P119B.is_met_in_time_by";
	static const char P120F[] = NS_CRM42 "P120F.occurs_before";
	static const char P120B[] = NS_CRM42 "P120B.occurs_after";
	static const char P121F[] = NS_CRM42 "P121F.overlaps_with";
	static const char P122F[] = NS_CRM42 "P122F.borders_with";
	static const char P123F[] = NS_CRM42 "P123F.resulted_in";
	static const char P123B[] = NS_CRM42 "P123B.resulted_from";
	static const char P124F[] = NS_CRM42 "P124F.transformed";
	static const char P124B[] = NS_CRM42 "P124B.was_transformed_by";
	static const char P125F[] = NS_CRM42 "P125F.used_object_of_type";
	static const char P125B[] = NS_CRM42 "P125B.was_type_of_object_used_in";
	static const char P126F[] = NS_CRM42 "P126F.employed";
	static const char P126B[] = NS_CRM42 "P126B.was_employed_in";
	static const char P127F[] = NS_CRM42 "P127F.has_broader_term";
	static const char P127B[] = NS_CRM42 "P127B.has_narrower_term";
	static const char P128F[] = NS_CRM42 "P128F.carries";
	static const char P128B[] = NS_CRM42 "P128B.is_carried_by";
	static const char P129F[] = NS_CRM42 "P129F.is_about";
	static const char P129B[] = NS_CRM42 "P129B.is_subject_of";
	static const char P130F[] = NS_CRM42 "P130F.shows_features_of";
	static const char P130B[] = NS_CRM42 "P130B.features_are_also_found_on";
	static const char P131F[] = NS_CRM42 "P131F.is_identified_by";
	static const char P131B[] = NS_CRM42 "P131B.identifies";
	static const char P132F[] = NS_CRM42 "P132F.overlaps_with";
	static const char P133F[] = NS_CRM42 "P133F.is_separated_from";
	static const char P134F[] = NS_CRM42 "P134F.continued";
	static const char P134B[] = NS_CRM42 "P134B.was_continued_by";
	static const char P135F[] = NS_CRM42 "P135F.created_type";
	static const char P135B[] = NS_CRM42 "P135B.was_created_by";
	static const char P136F[] = NS_CRM42 "P136F.was_based_on";
	static const char P136B[] = NS_CRM42 "P136B.supported_type_creation";
	static const char P137F[] = NS_CRM42 "P137F.is_exemplified_by";
	static const char P137B[] = NS_CRM42 "P137B.exemplifies";
	static const char P138F[] = NS_CRM42 "P138F.represents";
	static const char P138B[] = NS_CRM42 "P138B.has_representation";
	static const char P139F[] = NS_CRM42 "P139F.has_alternative_form";
	static const char P140F[] = NS_CRM42 "P140F.assigned_attribute_to";
	static const char P140B[] = NS_CRM42 "P140B.was_attributed_by";
	static const char P141F[] = NS_CRM42 "P141F.assigned";
	static const char P141B[] = NS_CRM42 "P141B.was_assigned_by";
   }    
}

#endif