"""
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_CRMEH
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
          NOTE: constants by convention only, not immutable in Python
Example : 
    import URI_CRMEH
    print(URI_CRMEH.EHE0001) # "http://purl.org/crmeh#EHE0001_EHProject"
License : https://mit-license.org
History :
23/02/2023 CFB Extracted from old script, updated to use F-strings
===============================================================================
"""
# Namespace
NS = "http://purl.org/crmeh#"

# Entities
EHE0001 = f"{NS}EHE0001_EHProject"
EHE0002 = f"{NS}EHE0002_ArchaeologicalSite"
EHE0003 = f"{NS}EHE0003_AreaOfInvestigation"
EHE0004 = f"{NS}EHE0004_SiteSubDivision"
EHE0005 = f"{NS}EHE0005_Group"
EHE0006 = f"{NS}EHE0006_GroupStuff"
EHE0007 = f"{NS}EHE0007_Context"
EHE0008 = f"{NS}EHE0008_ContextStuff"
EHE0009 = f"{NS}EHE0009_ContextFind"
EHE0010 = f"{NS}EHE0010_BulkFind"
EHE0011 = f"{NS}EHE0011_GroupEventRecord"
EHE0012 = f"{NS}EHE0012_ContextEventRecord"
EHE0013 = f"{NS}EHE0013_ContextSheet"
EHE0014 = f"{NS}EHE0014_ContextFindProductionEventRecord"
EHE0015 = f"{NS}EHE0015_ContextFindUseEventRecord"
EHE0016 = f"{NS}EHE0016_RecordDrawing"
EHE0017 = f"{NS}EHE0017_RecordPhotograph"
EHE0018 = f"{NS}EHE0018_ContextSample"
EHE0019 = f"{NS}EHE0019_AreaOfInvestigationDepiction"
EHE0020 = f"{NS}EHE0020_BulkFindComponentCount"
EHE0021 = f"{NS}EHE0021_EHProjectTimespan"
EHE0022 = f"{NS}EHE0022_ContextDepiction"
EHE0023 = f"{NS}EHE0023_ContextEventRecordNote"
EHE0024 = f"{NS}EHE0024_ContextEventRecordNoteType"
EHE0025 = f"{NS}EHE0025_ContextEventTimespan"
EHE0026 = f"{NS}EHE0026_ContextEventTimespanAppellation"
EHE0027 = f"{NS}EHE0027_ContextFindConditionAssessmentEventTimespan"
EHE0028 = f"{NS}EHE0028_ContextFindConditionAssessmentEventType"
EHE0029 = f"{NS}EHE0029_ContextFindConditionState"
EHE0030 = f"{NS}EHE0030_ContextFindMaterial"
EHE0031 = f"{NS}EHE0031_ContextFindMeasurement"
EHE0032 = f"{NS}EHE0032_ContextFindMeasurementEventTimespan"
EHE0033 = f"{NS}EHE0033_ContextFindMeasurementEventType"
EHE0034 = f"{NS}EHE0034_ContextFindMeasurementUnit"
EHE0035 = f"{NS}EHE0035_ContextFindMeasurementValue"
EHE0036 = f"{NS}EHE0036_ContextFindProductionEventRecordNote"
EHE0037 = f"{NS}EHE0037_ContextFindProductionEventRecordNoteType"
EHE0038 = f"{NS}EHE0038_ContextFindProductionEventTimespan"
EHE0039 = f"{NS}EHE0039_ContextFindProductionEventTimespanAppellation"
EHE0040 = f"{NS}EHE0040_ContextFindTreatmentLocation"
EHE0041 = f"{NS}EHE0041_ContextFindTreatmentProcedure"
EHE0042 = f"{NS}EHE0042_ContextFindTreatmentType"
EHE0043 = f"{NS}EHE0043_ContextFindUID"
EHE0044 = f"{NS}EHE0044_ContextFindUseEventRecordNote"
EHE0045 = f"{NS}EHE0045_ContextFindUseEventRecordNoteType"
EHE0046 = f"{NS}EHE0046_ContextNote"
EHE0047 = f"{NS}EHE0047_ContextNoteType"
EHE0048 = f"{NS}EHE0048_ContextRecord"
EHE0049 = f"{NS}EHE0049_ContextSampleMeasurement"
EHE0050 = f"{NS}EHE0050_ContextSampleMeasurementType"
EHE0051 = f"{NS}EHE0051_ContextSampleMeasurementUnit"
EHE0052 = f"{NS}EHE0052_ContextSampleMeasurementValue"
EHE0053 = f"{NS}EHE0053_ContextSampleType"
EHE0054 = f"{NS}EHE0054_ContextStuffMeasurement"
EHE0055 = f"{NS}EHE0055_ContextStuffMeasurementEventTimespan"
EHE0056 = f"{NS}EHE0056_ContextStuffMeasurementEventType"
EHE0057 = f"{NS}EHE0057_ContextStuffMeasurementUnit"
EHE0058 = f"{NS}EHE0058_ContextStuffMeasurementValue"
EHE0059 = f"{NS}EHE0059_ContextStuffNote"
EHE0060 = f"{NS}EHE0060_ContextStuffNoteType"
EHE0061 = f"{NS}EHE0061_ContextUID"
EHE0062 = f"{NS}EHE0062_FlotationSample"
EHE0063 = f"{NS}EHE0063_FlotationSampleResidue"
EHE0064 = f"{NS}EHE0064_FlotationSampleResidueMeasurement"
EHE0065 = f"{NS}EHE0065_FlotationSampleResidueMeasurementUnit"
EHE0066 = f"{NS}EHE0066_FlotationSampleResidueMeasurementValue"
EHE0067 = f"{NS}EHE0067_FlotationSampleResidueType"
EHE0068 = f"{NS}EHE0068_GroupEventRecordNote"
EHE0069 = f"{NS}EHE0069_GroupEventRecordNoteType"
EHE0070 = f"{NS}EHE0070_GroupEventTimespan"
EHE0071 = f"{NS}EHE0071_GroupEventTimespanAppellation"
EHE0072 = f"{NS}EHE0072_GroupEventType"
EHE0073 = f"{NS}EHE0073_GroupingPhasingProcedure"
EHE0074 = f"{NS}EHE0074_IdentifiedFeature"
EHE0075 = f"{NS}EHE0075_IdentifiedFeatureDepiction"
EHE0076 = f"{NS}EHE0076_ProjectDesign"
EHE0077 = f"{NS}EHE0077_ProjectTeamMember"
EHE0078 = f"{NS}EHE0078_ProjectTeamMemberRole"
EHE0079 = f"{NS}EHE0079_RecordDrawingNote"
EHE0080 = f"{NS}EHE0080_RecordDrawingNoteType"
EHE0081 = f"{NS}EHE0081_RecordDrawingReferenceType"
EHE0082 = f"{NS}EHE0082_RecordDrawingSheet"
EHE0083 = f"{NS}EHE0083_RecordPhotographNote"
EHE0084 = f"{NS}EHE0084_RecordPhotographNoteType"
EHE0085 = f"{NS}EHE0085_RecordPhotographReferenceType"
EHE0086 = f"{NS}EHE0086_ResponsibleAgent"
EHE0087 = f"{NS}EHE0087_SiteSubDivisionAppellation"
EHE0088 = f"{NS}EHE0088_SiteSubDivisionDepiction"
EHE0089 = f"{NS}EHE0089_StorageLocation"
EHE0090 = f"{NS}EHE0090_SurveyDataset"
EHE0091 = f"{NS}EHE0091_Timestamp"
EHE0092 = f"{NS}EHE0092_GroupUID"
EHE0093 = f"{NS}EHE0093_GroupDepiction"
EHE0094 = f"{NS}EHE0094_FlotationSampleResidueMeasurementType"
EHE0095 = f"{NS}EHE0095_ContextFindProductionEventLocation"
EHE0096 = f"{NS}EHE0096_ContextFindGeneralUse"
EHE0097 = f"{NS}EHE0097_ContextFindIntendedUse"
EHE0098 = f"{NS}EHE0098_ContextFindExcavationEventTimespan"
EHE0099 = f"{NS}EHE0099_ContextFindUseEventTimespan"
EHE1001 = f"{NS}EHE1001_ContextEvent"
EHE1002 = f"{NS}EHE1002_ContextFindProductionEvent"
EHE1003 = f"{NS}EHE1003_GroupEvent"
EHE1004 = f"{NS}EHE1004_ContextFindDepositionEvent"
EHE1005 = f"{NS}EHE1005_ContextFindUseEvent"
EHE2001 = f"{NS}EHE2001_ContextExcavationEvent"
EHE2002 = f"{NS}EHE2002_ContextFindClassificationEvent"
EHE2003 = f"{NS}EHE2003_ContextFindTreatmentEvent"
EHE2004 = f"{NS}EHE2004_GroupingPhasingEvent"
EHE2005 = f"{NS}EHE2005_ContextFindDatingEvent"
EHE2006 = f"{NS}EHE2006_ContextSamplingEvent"
EHE2007 = f"{NS}EHE2007_SurveyEvent"
EHE2008 = f"{NS}EHE2008_ProcessSurveyDatasetEvent"
EHE2009 = f"{NS}EHE2009_TransferObjectEvent"
EHE2010 = f"{NS}EHE2010_DepictionEvent"
EHE2011 = f"{NS}EHE2011_BulkFindItemRemovalEvent"
EHE2012 = f"{NS}EHE2012_ContextFindConditionAssessmentEvent"
EHE2013 = f"{NS}EHE2013_ContextFindIdentifierAssignmentEvent"
EHE2014 = f"{NS}EHE2014_ContextFindUseAssessmentEvent"
EHE2015 = f"{NS}EHE2015_ContextSampleProcessingEvent"
EHE2016 = f"{NS}EHE2016_ContextStuffMeasurementEvent"
EHE2017 = f"{NS}EHE2017_FlotationSampleProcessingEvent"
EHE2018 = f"{NS}EHE2018_FlotationSampleResidueProcessingEvent"
EHE2019 = f"{NS}EHE2019_SimpleNameAssignmentEvent"
EHE2020 = f"{NS}EHE2020_ContextFindMeasurementEvent"
EHE2021 = f"{NS}EHE2021_BulkFindAssessment"

# Properties
EHP1F = f"{NS}EHP1F_is_trace_of"
EHP2F = f"{NS}EHP2F_is_trace_of_type"
EHP3B = f"{NS}EHP3B_was_occupied_by"
EHP3F = f"{NS}EHP3F_occupied"
EHP4B = f"{NS}EHP4B_is_depicted_by"
EHP4F = f"{NS}EHP4F_depicts"
EHP5F = f"{NS}EHP5F_is_thesaurus_concept"
