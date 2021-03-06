#!/usr/bin/env python
#############################
# Module:   URI_CRMEH.py
# Author:   C Binding
# Date:     2008-07-09
# Version:  Draft 0.1
'''
Module defines URI constants for CRMEH RDF entities and properties
'''
###############################
# Log:
# 2008-07-09    CFB - Initially created module
################################

NS_CRMEH = "http://purl.org/crmeh#"
#Entity types
EHE0001 = NS_CRMEH + "EHE0001_EHProject"
EHE0002 = NS_CRMEH + "EHE0002_ArchaeologicalSite"
EHE0003 = NS_CRMEH + "EHE0003_AreaOfInvestigation"
EHE0004 = NS_CRMEH + "EHE0004_SiteSubDivision"
EHE0005 = NS_CRMEH + "EHE0005_Group"
EHE0006 = NS_CRMEH + "EHE0006_GroupStuff"
EHE0007 = NS_CRMEH + "EHE0007_Context"
EHE0008 = NS_CRMEH + "EHE0008_ContextStuff"
EHE0009 = NS_CRMEH + "EHE0009_ContextFind"
EHE0010 = NS_CRMEH + "EHE0010_BulkFind"
EHE0011 = NS_CRMEH + "EHE0011_GroupEventRecord"
EHE0012 = NS_CRMEH + "EHE0012_ContextEventRecord"
EHE0013 = NS_CRMEH + "EHE0013_ContextSheet"
EHE0014 = NS_CRMEH + "EHE0014_ContextFindProductionEventRecord"
EHE0015 = NS_CRMEH + "EHE0015_ContextFindUseEventRecord"
EHE0016 = NS_CRMEH + "EHE0016_RecordDrawing"
EHE0017 = NS_CRMEH + "EHE0017_RecordPhotograph"
EHE0018 = NS_CRMEH + "EHE0018_ContextSample"
EHE0019 = NS_CRMEH + "EHE0019_AreaOfInvestigationDepiction"
EHE0020 = NS_CRMEH + "EHE0020_BulkFindComponentCount"
EHE0021 = NS_CRMEH + "EHE0021_EHProjectTimespan"
EHE0022 = NS_CRMEH + "EHE0022_ContextDepiction"
EHE0023 = NS_CRMEH + "EHE0023_ContextEventRecordNote"
EHE0024 = NS_CRMEH + "EHE0024_ContextEventRecordNoteType"
EHE0025 = NS_CRMEH + "EHE0025_ContextEventTimespan"
EHE0026 = NS_CRMEH + "EHE0026_ContextEventTimespanAppellation"
EHE0027 = NS_CRMEH + "EHE0027_ContextFindConditionAssessmentEventTimespan"
EHE0028 = NS_CRMEH + "EHE0028_ContextFindConditionAssessmentEventType"
EHE0029 = NS_CRMEH + "EHE0029_ContextFindConditionState"
EHE0030 = NS_CRMEH + "EHE0030_ContextFindMaterial"
EHE0031 = NS_CRMEH + "EHE0031_ContextFindMeasurement"
EHE0032 = NS_CRMEH + "EHE0032_ContextFindMeasurementEventTimespan"
EHE0033 = NS_CRMEH + "EHE0033_ContextFindMeasurementEventType"
EHE0034 = NS_CRMEH + "EHE0034_ContextFindMeasurementUnit"
EHE0035 = NS_CRMEH + "EHE0035_ContextFindMeasurementValue"
EHE0036 = NS_CRMEH + "EHE0036_ContextFindProductionEventRecordNote"
EHE0037 = NS_CRMEH + "EHE0037_ContextFindProductionEventRecordNoteType"
EHE0038 = NS_CRMEH + "EHE0038_ContextFindProductionEventTimespan"
EHE0039 = NS_CRMEH + "EHE0039_ContextFindProductionEventTimespanAppellation"
EHE0040 = NS_CRMEH + "EHE0040_ContextFindTreatmentLocation"
EHE0041 = NS_CRMEH + "EHE0041_ContextFindTreatmentProcedure"
EHE0042 = NS_CRMEH + "EHE0042_ContextFindTreatmentType"
EHE0043 = NS_CRMEH + "EHE0043_ContextFindUID"
EHE0044 = NS_CRMEH + "EHE0044_ContextFindUseEventRecordNote"
EHE0045 = NS_CRMEH + "EHE0045_ContextFindUseEventRecordNoteType"
EHE0046 = NS_CRMEH + "EHE0046_ContextNote"
EHE0047 = NS_CRMEH + "EHE0047_ContextNoteType"
EHE0048 = NS_CRMEH + "EHE0048_ContextRecord"
EHE0049 = NS_CRMEH + "EHE0049_ContextSampleMeasurement"
EHE0050 = NS_CRMEH + "EHE0050_ContextSampleMeasurementType"
EHE0051 = NS_CRMEH + "EHE0051_ContextSampleMeasurementUnit"
EHE0052 = NS_CRMEH + "EHE0052_ContextSampleMeasurementValue"
EHE0053 = NS_CRMEH + "EHE0053_ContextSampleType"
EHE0054 = NS_CRMEH + "EHE0054_ContextStuffMeasurement"
EHE0055 = NS_CRMEH + "EHE0055_ContextStuffMeasurementEventTimespan"
EHE0056 = NS_CRMEH + "EHE0056_ContextStuffMeasurementEventType"
EHE0057 = NS_CRMEH + "EHE0057_ContextStuffMeasurementUnit"
EHE0058 = NS_CRMEH + "EHE0058_ContextStuffMeasurementValue"
EHE0059 = NS_CRMEH + "EHE0059_ContextStuffNote"
EHE0060 = NS_CRMEH + "EHE0060_ContextStuffNoteType"
EHE0061 = NS_CRMEH + "EHE0061_ContextUID"
EHE0062 = NS_CRMEH + "EHE0062_FlotationSample"
EHE0063 = NS_CRMEH + "EHE0063_FlotationSampleResidue"
EHE0064 = NS_CRMEH + "EHE0064_FlotationSampleResidueMeasurement"
EHE0065 = NS_CRMEH + "EHE0065_FlotationSampleResidueMeasurementUnit"
EHE0066 = NS_CRMEH + "EHE0066_FlotationSampleResidueMeasurementValue"
EHE0067 = NS_CRMEH + "EHE0067_FlotationSampleResidueType"
EHE0068 = NS_CRMEH + "EHE0068_GroupEventRecordNote"
EHE0069 = NS_CRMEH + "EHE0069_GroupEventRecordNoteType"
EHE0070 = NS_CRMEH + "EHE0070_GroupEventTimespan"
EHE0071 = NS_CRMEH + "EHE0071_GroupEventTimespanAppellation"
EHE0072 = NS_CRMEH + "EHE0072_GroupEventType"
EHE0073 = NS_CRMEH + "EHE0073_GroupingPhasingProcedure"
EHE0074 = NS_CRMEH + "EHE0074_IdentifiedFeature"
EHE0075 = NS_CRMEH + "EHE0075_IdentifiedFeatureDepiction"
EHE0076 = NS_CRMEH + "EHE0076_ProjectDesign"
EHE0077 = NS_CRMEH + "EHE0077_ProjectTeamMember"
EHE0078 = NS_CRMEH + "EHE0078_ProjectTeamMemberRole"
EHE0079 = NS_CRMEH + "EHE0079_RecordDrawingNote"
EHE0080 = NS_CRMEH + "EHE0080_RecordDrawingNoteType"
EHE0081 = NS_CRMEH + "EHE0081_RecordDrawingReferenceType"
EHE0082 = NS_CRMEH + "EHE0082_RecordDrawingSheet"
EHE0083 = NS_CRMEH + "EHE0083_RecordPhotographNote"
EHE0084 = NS_CRMEH + "EHE0084_RecordPhotographNoteType"
EHE0085 = NS_CRMEH + "EHE0085_RecordPhotographReferenceType"
EHE0086 = NS_CRMEH + "EHE0086_ResponsibleAgent"
EHE0087 = NS_CRMEH + "EHE0087_SiteSubDivisionAppellation"
EHE0088 = NS_CRMEH + "EHE0088_SiteSubDivisionDepiction"
EHE0089 = NS_CRMEH + "EHE0089_StorageLocation"
EHE0090 = NS_CRMEH + "EHE0090_SurveyDataset"
EHE0091 = NS_CRMEH + "EHE0091_Timestamp"
EHE0092 = NS_CRMEH + "EHE0092_GroupUID"
EHE0093 = NS_CRMEH + "EHE0093_GroupDepiction"
EHE0094 = NS_CRMEH + "EHE0094_FlotationSampleResidueMeasurementType"
EHE0095 = NS_CRMEH + "EHE0095_ContextFindProductionEventLocation"
EHE0096 = NS_CRMEH + "EHE0096_ContextFindGeneralUse"
EHE0097 = NS_CRMEH + "EHE0097_ContextFindIntendedUse"
EHE0098 = NS_CRMEH + "EHE0098_ContextFindExcavationEventTimespan"
EHE0099 = NS_CRMEH + "EHE0099_ContextFindUseEventTimespan"
EHE1001 = NS_CRMEH + "EHE1001_ContextEvent"
EHE1002 = NS_CRMEH + "EHE1002_ContextFindProductionEvent"
EHE1003 = NS_CRMEH + "EHE1003_GroupEvent"
EHE1004 = NS_CRMEH + "EHE1004_ContextFindDepositionEvent"
EHE1005 = NS_CRMEH + "EHE1005_ContextFindUseEvent"
EHE2001 = NS_CRMEH + "EHE2001_ContextExcavationEvent"
EHE2002 = NS_CRMEH + "EHE2002_ContextFindClassificationEvent"
EHE2003 = NS_CRMEH + "EHE2003_ContextFindTreatmentEvent"
EHE2004 = NS_CRMEH + "EHE2004_GroupingPhasingEvent"
EHE2005 = NS_CRMEH + "EHE2005_ContextFindDatingEvent"
EHE2006 = NS_CRMEH + "EHE2006_ContextSamplingEvent"
EHE2007 = NS_CRMEH + "EHE2007_SurveyEvent"
EHE2008 = NS_CRMEH + "EHE2008_ProcessSurveyDatasetEvent"
EHE2009 = NS_CRMEH + "EHE2009_TransferObjectEvent"
EHE2010 = NS_CRMEH + "EHE2010_DepictionEvent"
EHE2011 = NS_CRMEH + "EHE2011_BulkFindItemRemovalEvent"
EHE2012 = NS_CRMEH + "EHE2012_ContextFindConditionAssessmentEvent"
EHE2013 = NS_CRMEH + "EHE2013_ContextFindIdentifierAssignmentEvent"
EHE2014 = NS_CRMEH + "EHE2014_ContextFindUseAssessmentEvent"
EHE2015 = NS_CRMEH + "EHE2015_ContextSampleProcessingEvent"
EHE2016 = NS_CRMEH + "EHE2016_ContextStuffMeasurementEvent"
EHE2017 = NS_CRMEH + "EHE2017_FlotationSampleProcessingEvent"
EHE2018 = NS_CRMEH + "EHE2018_FlotationSampleResidueProcessingEvent"
EHE2019 = NS_CRMEH + "EHE2019_SimpleNameAssignmentEvent"
EHE2020 = NS_CRMEH + "EHE2020_ContextFindMeasurementEvent"
EHE2021 = NS_CRMEH + "EHE2021_BulkFindAssessment"    
#Property types
EHP1F = NS_CRMEH + "EHP1F_is_trace_of"
EHP2F = NS_CRMEH + "EHP2F_is_trace_of_type"
EHP3B = NS_CRMEH + "EHP3B_was_occupied_by"
EHP3F = NS_CRMEH + "EHP3F_occupied"
EHP4B = NS_CRMEH + "EHP4B_is_depicted_by"
EHP4F = NS_CRMEH + "EHP4F_depicts"
EHP5F = NS_CRMEH + "EHP5F_is_thesaurus_concept"