#ifndef _URI_CRMEH_H 
#define _URI_CRMEH_H 

#define NS_CRMEH "http://purl.org/crmeh#"    
      
namespace URI
{
	// usage: URI::CRMEH::E1, URI::CRMEH::P2 etc.	
   namespace CRMEH
   {  
    // Entity types
    static const char EHE0001[] = NS_CRMEH "EHE0001_EHProject";
	static const char EHE0002[] = NS_CRMEH "EHE0002_ArchaeologicalSite";
	static const char EHE0003[] = NS_CRMEH "EHE0003_AreaOfInvestigation";
	static const char EHE0004[] = NS_CRMEH "EHE0004_SiteSubDivision";
	static const char EHE0005[] = NS_CRMEH "EHE0005_Group";
	static const char EHE0006[] = NS_CRMEH "EHE0006_GroupStuff";
	static const char EHE0007[] = NS_CRMEH "EHE0007_Context";
	static const char EHE0008[] = NS_CRMEH "EHE0008_ContextStuff";
	static const char EHE0009[] = NS_CRMEH "EHE0009_ContextFind";
	static const char EHE0010[] = NS_CRMEH "EHE0010_BulkFind";
	static const char EHE0011[] = NS_CRMEH "EHE0011_GroupEventRecord";
	static const char EHE0012[] = NS_CRMEH "EHE0012_ContextEventRecord";
	static const char EHE0013[] = NS_CRMEH "EHE0013_ContextSheet";
	static const char EHE0014[] = NS_CRMEH "EHE0014_ContextFindProductionEventRecord";
	static const char EHE0015[] = NS_CRMEH "EHE0015_ContextFindUseEventRecord";
	static const char EHE0016[] = NS_CRMEH "EHE0016_RecordDrawing";
	static const char EHE0017[] = NS_CRMEH "EHE0017_RecordPhotograph";
	static const char EHE0018[] = NS_CRMEH "EHE0018_ContextSample";
	static const char EHE0019[] = NS_CRMEH "EHE0019_AreaOfInvestigationDepiction";
	static const char EHE0020[] = NS_CRMEH "EHE0020_BulkFindComponentCount";
	static const char EHE0021[] = NS_CRMEH "EHE0021_EHProjectTimespan";
	static const char EHE0022[] = NS_CRMEH "EHE0022_ContextDepiction";
	static const char EHE0023[] = NS_CRMEH "EHE0023_ContextEventRecordNote";
	static const char EHE0024[] = NS_CRMEH "EHE0024_ContextEventRecordNoteType";
	static const char EHE0025[] = NS_CRMEH "EHE0025_ContextEventTimespan";
	static const char EHE0026[] = NS_CRMEH "EHE0026_ContextEventTimespanAppellation";
	static const char EHE0027[] = NS_CRMEH "EHE0027_ContextFindConditionAssessmentEventTimespan";
	static const char EHE0028[] = NS_CRMEH "EHE0028_ContextFindConditionAssessmentEventType";
	static const char EHE0029[] = NS_CRMEH "EHE0029_ContextFindConditionState";
	static const char EHE0030[] = NS_CRMEH "EHE0030_ContextFindMaterial";
	static const char EHE0031[] = NS_CRMEH "EHE0031_ContextFindMeasurement";
	static const char EHE0032[] = NS_CRMEH "EHE0032_ContextFindMeasurementEventTimespan";
	static const char EHE0033[] = NS_CRMEH "EHE0033_ContextFindMeasurementEventType";
	static const char EHE0034[] = NS_CRMEH "EHE0034_ContextFindMeasurementUnit";
	static const char EHE0035[] = NS_CRMEH "EHE0035_ContextFindMeasurementValue";
	static const char EHE0036[] = NS_CRMEH "EHE0036_ContextFindProductionEventRecordNote";
	static const char EHE0037[] = NS_CRMEH "EHE0037_ContextFindProductionEventRecordNoteType";
	static const char EHE0038[] = NS_CRMEH "EHE0038_ContextFindProductionEventTimespan";
	static const char EHE0039[] = NS_CRMEH "EHE0039_ContextFindProductionEventTimespanAppellation";
	static const char EHE0040[] = NS_CRMEH "EHE0040_ContextFindTreatmentLocation";
	static const char EHE0041[] = NS_CRMEH "EHE0041_ContextFindTreatmentProcedure";
	static const char EHE0042[] = NS_CRMEH "EHE0042_ContextFindTreatmentType";
	static const char EHE0043[] = NS_CRMEH "EHE0043_ContextFindUID";
	static const char EHE0044[] = NS_CRMEH "EHE0044_ContextFindUseEventRecordNote";
	static const char EHE0045[] = NS_CRMEH "EHE0045_ContextFindUseEventRecordNoteType";
	static const char EHE0046[] = NS_CRMEH "EHE0046_ContextNote";
	static const char EHE0047[] = NS_CRMEH "EHE0047_ContextNoteType";
	static const char EHE0048[] = NS_CRMEH "EHE0048_ContextRecord";
	static const char EHE0049[] = NS_CRMEH "EHE0049_ContextSampleMeasurement";
	static const char EHE0050[] = NS_CRMEH "EHE0050_ContextSampleMeasurementType";
	static const char EHE0051[] = NS_CRMEH "EHE0051_ContextSampleMeasurementUnit";
	static const char EHE0052[] = NS_CRMEH "EHE0052_ContextSampleMeasurementValue";
	static const char EHE0053[] = NS_CRMEH "EHE0053_ContextSampleType";
	static const char EHE0054[] = NS_CRMEH "EHE0054_ContextStuffMeasurement";
	static const char EHE0055[] = NS_CRMEH "EHE0055_ContextStuffMeasurementEventTimespan";
	static const char EHE0056[] = NS_CRMEH "EHE0056_ContextStuffMeasurementEventType";
	static const char EHE0057[] = NS_CRMEH "EHE0057_ContextStuffMeasurementUnit";
	static const char EHE0058[] = NS_CRMEH "EHE0058_ContextStuffMeasurementValue";
	static const char EHE0059[] = NS_CRMEH "EHE0059_ContextStuffNote";
	static const char EHE0060[] = NS_CRMEH "EHE0060_ContextStuffNoteType";
	static const char EHE0061[] = NS_CRMEH "EHE0061_ContextUID";
	static const char EHE0062[] = NS_CRMEH "EHE0062_FlotationSample";
	static const char EHE0063[] = NS_CRMEH "EHE0063_FlotationSampleResidue";
	static const char EHE0064[] = NS_CRMEH "EHE0064_FlotationSampleResidueMeasurement";
	static const char EHE0065[] = NS_CRMEH "EHE0065_FlotationSampleResidueMeasurementUnit";
	static const char EHE0066[] = NS_CRMEH "EHE0066_FlotationSampleResidueMeasurementValue";
	static const char EHE0067[] = NS_CRMEH "EHE0067_FlotationSampleResidueType";
	static const char EHE0068[] = NS_CRMEH "EHE0068_GroupEventRecordNote";
	static const char EHE0069[] = NS_CRMEH "EHE0069_GroupEventRecordNoteType";
	static const char EHE0070[] = NS_CRMEH "EHE0070_GroupEventTimespan";
	static const char EHE0071[] = NS_CRMEH "EHE0071_GroupEventTimespanAppellation";
	static const char EHE0072[] = NS_CRMEH "EHE0072_GroupEventType";
	static const char EHE0073[] = NS_CRMEH "EHE0073_GroupingPhasingProcedure";
	static const char EHE0074[] = NS_CRMEH "EHE0074_IdentifiedFeature";
	static const char EHE0075[] = NS_CRMEH "EHE0075_IdentifiedFeatureDepiction";
	static const char EHE0076[] = NS_CRMEH "EHE0076_ProjectDesign";
	static const char EHE0077[] = NS_CRMEH "EHE0077_ProjectTeamMember";
	static const char EHE0078[] = NS_CRMEH "EHE0078_ProjectTeamMemberRole";
	static const char EHE0079[] = NS_CRMEH "EHE0079_RecordDrawingNote";
	static const char EHE0080[] = NS_CRMEH "EHE0080_RecordDrawingNoteType";
	static const char EHE0081[] = NS_CRMEH "EHE0081_RecordDrawingReferenceType";
	static const char EHE0082[] = NS_CRMEH "EHE0082_RecordDrawingSheet";
	static const char EHE0083[] = NS_CRMEH "EHE0083_RecordPhotographNote";
	static const char EHE0084[] = NS_CRMEH "EHE0084_RecordPhotographNoteType";
	static const char EHE0085[] = NS_CRMEH "EHE0085_RecordPhotographReferenceType";
	static const char EHE0086[] = NS_CRMEH "EHE0086_ResponsibleAgent";
	static const char EHE0087[] = NS_CRMEH "EHE0087_SiteSubDivisionAppellation";
	static const char EHE0088[] = NS_CRMEH "EHE0088_SiteSubDivisionDepiction";
	static const char EHE0089[] = NS_CRMEH "EHE0089_StorageLocation";
	static const char EHE0090[] = NS_CRMEH "EHE0090_SurveyDataset";
	static const char EHE0091[] = NS_CRMEH "EHE0091_Timestamp";
	static const char EHE0092[] = NS_CRMEH "EHE0092_GroupUID";
	static const char EHE0093[] = NS_CRMEH "EHE0093_GroupDepiction";
	static const char EHE0094[] = NS_CRMEH "EHE0094_FlotationSampleResidueMeasurementType";
	static const char EHE0095[] = NS_CRMEH "EHE0095_ContextFindProductionEventLocation";
	static const char EHE0096[] = NS_CRMEH "EHE0096_ContextFindGeneralUse";
	static const char EHE0097[] = NS_CRMEH "EHE0097_ContextFindIntendedUse";
	static const char EHE0098[] = NS_CRMEH "EHE0098_ContextFindExcavationEventTimespan";
	static const char EHE0099[] = NS_CRMEH "EHE0099_ContextFindUseEventTimespan";
	static const char EHE1001[] = NS_CRMEH "EHE1001_ContextEvent";
	static const char EHE1002[] = NS_CRMEH "EHE1002_ContextFindProductionEvent";
	static const char EHE1003[] = NS_CRMEH "EHE1003_GroupEvent";
	static const char EHE1004[] = NS_CRMEH "EHE1004_ContextFindDepositionEvent";
	static const char EHE1005[] = NS_CRMEH "EHE1005_ContextFindUseEvent";
	static const char EHE2001[] = NS_CRMEH "EHE2001_ContextExcavationEvent";
	static const char EHE2002[] = NS_CRMEH "EHE2002_ContextFindClassificationEvent";
	static const char EHE2003[] = NS_CRMEH "EHE2003_ContextFindTreatmentEvent";
	static const char EHE2004[] = NS_CRMEH "EHE2004_GroupingPhasingEvent";
	static const char EHE2005[] = NS_CRMEH "EHE2005_ContextFindDatingEvent";
	static const char EHE2006[] = NS_CRMEH "EHE2006_ContextSamplingEvent";
	static const char EHE2007[] = NS_CRMEH "EHE2007_SurveyEvent";
	static const char EHE2008[] = NS_CRMEH "EHE2008_ProcessSurveyDatasetEvent";
	static const char EHE2009[] = NS_CRMEH "EHE2009_TransferObjectEvent";
	static const char EHE2010[] = NS_CRMEH "EHE2010_DepictionEvent";
	static const char EHE2011[] = NS_CRMEH "EHE2011_BulkFindItemRemovalEvent";
	static const char EHE2012[] = NS_CRMEH "EHE2012_ContextFindConditionAssessmentEvent";
	static const char EHE2013[] = NS_CRMEH "EHE2013_ContextFindIdentifierAssignmentEvent";
	static const char EHE2014[] = NS_CRMEH "EHE2014_ContextFindUseAssessmentEvent";
	static const char EHE2015[] = NS_CRMEH "EHE2015_ContextSampleProcessingEvent";
	static const char EHE2016[] = NS_CRMEH "EHE2016_ContextStuffMeasurementEvent";
	static const char EHE2017[] = NS_CRMEH "EHE2017_FlotationSampleProcessingEvent";
	static const char EHE2018[] = NS_CRMEH "EHE2018_FlotationSampleResidueProcessingEvent";
	static const char EHE2019[] = NS_CRMEH "EHE2019_SimpleNameAssignmentEvent";
	static const char EHE2020[] = NS_CRMEH "EHE2020_ContextFindMeasurementEvent";
	static const char EHE2021[] = NS_CRMEH "EHE2021_BulkFindAssessment";
	// Property types
	static const char EHP1F[] = NS_CRMEH "EHP1F_is_trace_of";
	static const char EHP2F[] = NS_CRMEH "EHP2F_is_trace_of_type";
	static const char EHP3B[] = NS_CRMEH "EHP3B_was_occupied_by";
	static const char EHP3F[] = NS_CRMEH "EHP3F_occupied";
	static const char EHP4B[] = NS_CRMEH "EHP4B_is_depicted_by";
	static const char EHP4F[] = NS_CRMEH "EHP4F_depicts";
	static const char EHP5F[] = NS_CRMEH "EHP5F_is_thesaurus_concept";
   }    
}

#endif
