/*
================================================================================
Creator : Ceri Binding, University of Glamorgan
Project	: URI
Classes	: CRMEH
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
    /// Defines RDF namespace, entity and property URI constants for CRMEH model
    /// </summary>
    /// <example> This sample code shows how use the constants defined in the class
    /// <code>
    /// // C# example:
    /// String s = URI.CRMEH.EHE0003; 
    /// // = http://purl.org/crmeh#EHE0003_AreaOfInvestigation  
    /// </code>
    ///</example>
    public static class CRMEH
    {
        #region namespace
        /// <summary>http://purl.org/crmeh#</summary>
        public const String NS = "http://purl.org/crmeh#";
        //public const String NS_PREFIX = "crmeh";
        #endregion

        #region entities
        /// <summary>http://purl.org/crmeh#EHE0001_EHProject</summary>
        public const String EHE0001 = NS + "EHE0001_EHProject";
        /// <summary>http://purl.org/crmeh#EHE0002_ArchaeologicalSite</summary>
        public const String EHE0002 = NS + "EHE0002_ArchaeologicalSite";
        /// <summary>http://purl.org/crmeh#EHE0003_AreaOfInvestigation</summary>
        public const String EHE0003 = NS + "EHE0003_AreaOfInvestigation";
        /// <summary>http://purl.org/crmeh#EHE0004_SiteSubDivision</summary>
        public const String EHE0004 = NS + "EHE0004_SiteSubDivision";
        /// <summary>http://purl.org/crmeh#EHE0005_Group</summary>
        public const String EHE0005 = NS + "EHE0005_Group";
        /// <summary>http://purl.org/crmeh#EHE0006_GroupStuff</summary>
        public const String EHE0006 = NS + "EHE0006_GroupStuff";
        /// <summary>http://purl.org/crmeh#EHE0007_Context</summary>
        public const String EHE0007 = NS + "EHE0007_Context";
        /// <summary>http://purl.org/crmeh#EHE0008_ContextStuff</summary>
        public const String EHE0008 = NS + "EHE0008_ContextStuff";
        /// <summary>http://purl.org/crmeh#EHE0009_ContextFind</summary>
        public const String EHE0009 = NS + "EHE0009_ContextFind";
        /// <summary>http://purl.org/crmeh#EHE0010_BulkFind</summary>
        public const String EHE0010 = NS + "EHE0010_BulkFind";
        /// <summary>http://purl.org/crmeh#EHE0011_GroupEventRecord</summary>
        public const String EHE0011 = NS + "EHE0011_GroupEventRecord";
        /// <summary>http://purl.org/crmeh#EHE0012_ContextEventRecord</summary>
        public const String EHE0012 = NS + "EHE0012_ContextEventRecord";
        /// <summary>http://purl.org/crmeh#EHE0013_ContextSheet</summary>
        public const String EHE0013 = NS + "EHE0013_ContextSheet";
        /// <summary>http://purl.org/crmeh#EHE0014_ContextFindProductionEventRecord</summary>
        public const String EHE0014 = NS + "EHE0014_ContextFindProductionEventRecord";
        /// <summary>http://purl.org/crmeh#EHE0015_ContextFindUseEventRecord</summary>
        public const String EHE0015 = NS + "EHE0015_ContextFindUseEventRecord";
        /// <summary>http://purl.org/crmeh#EHE0016_RecordDrawing</summary>
        public const String EHE0016 = NS + "EHE0016_RecordDrawing";
        /// <summary>http://purl.org/crmeh#EHE0017_RecordPhotograph</summary>
        public const String EHE0017 = NS + "EHE0017_RecordPhotograph";
        /// <summary>http://purl.org/crmeh#EHE0018_ContextSample</summary>
        public const String EHE0018 = NS + "EHE0018_ContextSample";
        /// <summary>http://purl.org/crmeh#EHE0019_AreaOfInvestigationDepiction</summary>
        public const String EHE0019 = NS + "EHE0019_AreaOfInvestigationDepiction";
        /// <summary>http://purl.org/crmeh#EHE0020_BulkFindComponentCount</summary>
        public const String EHE0020 = NS + "EHE0020_BulkFindComponentCount";
        /// <summary>http://purl.org/crmeh#EHE0021_EHProjectTimespan</summary>
        public const String EHE0021 = NS + "EHE0021_EHProjectTimespan";
        /// <summary>http://purl.org/crmeh#EHE0022_ContextDepiction</summary>
        public const String EHE0022 = NS + "EHE0022_ContextDepiction";
        /// <summary>http://purl.org/crmeh#EHE0023_ContextEventRecordNote</summary>
        public const String EHE0023 = NS + "EHE0023_ContextEventRecordNote";
        /// <summary>http://purl.org/crmeh#EHE0024_ContextEventRecordNoteType</summary>
        public const String EHE0024 = NS + "EHE0024_ContextEventRecordNoteType";
        /// <summary>http://purl.org/crmeh#EHE0025_ContextEventTimespan</summary>
        public const String EHE0025 = NS + "EHE0025_ContextEventTimespan";
        /// <summary>http://purl.org/crmeh#EHE0026_ContextEventTimespanAppellation</summary>
        public const String EHE0026 = NS + "EHE0026_ContextEventTimespanAppellation";
        /// <summary>http://purl.org/crmeh#EHE0027_ContextFindConditionAssessmentEventTimespan</summary>
        public const String EHE0027 = NS + "EHE0027_ContextFindConditionAssessmentEventTimespan";
        /// <summary>http://purl.org/crmeh#EHE0028_ContextFindConditionAssessmentEventType</summary>
        public const String EHE0028 = NS + "EHE0028_ContextFindConditionAssessmentEventType";
        /// <summary>http://purl.org/crmeh#EHE0029_ContextFindConditionState</summary>
        public const String EHE0029 = NS + "EHE0029_ContextFindConditionState";
        /// <summary>http://purl.org/crmeh#EHE0030_ContextFindMaterial</summary>
        public const String EHE0030 = NS + "EHE0030_ContextFindMaterial";
        /// <summary>http://purl.org/crmeh#EHE0031_ContextFindMeasurement</summary>
        public const String EHE0031 = NS + "EHE0031_ContextFindMeasurement";
        /// <summary>http://purl.org/crmeh#EHE0032_ContextFindMeasurementEventTimespan</summary>
        public const String EHE0032 = NS + "EHE0032_ContextFindMeasurementEventTimespan";
        /// <summary>http://purl.org/crmeh#EHE0033_ContextFindMeasurementEventType</summary>
        public const String EHE0033 = NS + "EHE0033_ContextFindMeasurementEventType";
        /// <summary>http://purl.org/crmeh#EHE0034_ContextFindMeasurementUnit</summary>
        public const String EHE0034 = NS + "EHE0034_ContextFindMeasurementUnit";
        /// <summary>http://purl.org/crmeh#EHE0035_ContextFindMeasurementValue</summary>
        public const String EHE0035 = NS + "EHE0035_ContextFindMeasurementValue";
        /// <summary>http://purl.org/crmeh#EHE0036_ContextFindProductionEventRecordNote</summary>
        public const String EHE0036 = NS + "EHE0036_ContextFindProductionEventRecordNote";
        /// <summary>http://purl.org/crmeh#EHE0037_ContextFindProductionEventRecordNoteType</summary>
        public const String EHE0037 = NS + "EHE0037_ContextFindProductionEventRecordNoteType";
        /// <summary>http://purl.org/crmeh#EHE0038_ContextFindProductionEventTimespan</summary>
        public const String EHE0038 = NS + "EHE0038_ContextFindProductionEventTimespan";
        /// <summary>http://purl.org/crmeh#EHE0039_ContextFindProductionEventTimespanAppellation</summary>
        public const String EHE0039 = NS + "EHE0039_ContextFindProductionEventTimespanAppellation";
        /// <summary>http://purl.org/crmeh#EHE0040_ContextFindTreatmentLocation</summary>
        public const String EHE0040 = NS + "EHE0040_ContextFindTreatmentLocation";
        /// <summary>http://purl.org/crmeh#EHE0041_ContextFindTreatmentProcedure</summary>
        public const String EHE0041 = NS + "EHE0041_ContextFindTreatmentProcedure";
        /// <summary>http://purl.org/crmeh#EHE0042_ContextFindTreatmentType</summary>
        public const String EHE0042 = NS + "EHE0042_ContextFindTreatmentType";
        /// <summary>http://purl.org/crmeh#EHE0043_ContextFindUID</summary>
        public const String EHE0043 = NS + "EHE0043_ContextFindUID";
        /// <summary>http://purl.org/crmeh#EHE0044_ContextFindUseEventRecordNote</summary>
        public const String EHE0044 = NS + "EHE0044_ContextFindUseEventRecordNote";
        /// <summary>http://purl.org/crmeh#EHE0045_ContextFindUseEventRecordNoteType</summary>
        public const String EHE0045 = NS + "EHE0045_ContextFindUseEventRecordNoteType";
        /// <summary>http://purl.org/crmeh#EHE0046_ContextNote</summary>
        public const String EHE0046 = NS + "EHE0046_ContextNote";
        /// <summary>http://purl.org/crmeh#EHE0047_ContextNoteType</summary>
        public const String EHE0047 = NS + "EHE0047_ContextNoteType";
        /// <summary>http://purl.org/crmeh#EHE0048_ContextRecord</summary>
        public const String EHE0048 = NS + "EHE0048_ContextRecord";
        /// <summary>http://purl.org/crmeh#EHE0049_ContextSampleMeasurement</summary>
        public const String EHE0049 = NS + "EHE0049_ContextSampleMeasurement";
        /// <summary>http://purl.org/crmeh#EHE0050_ContextSampleMeasurementType</summary>
        public const String EHE0050 = NS + "EHE0050_ContextSampleMeasurementType";
        /// <summary>http://purl.org/crmeh#EHE0051_ContextSampleMeasurementUnit</summary>
        public const String EHE0051 = NS + "EHE0051_ContextSampleMeasurementUnit";
        /// <summary>http://purl.org/crmeh#EHE0052_ContextSampleMeasurementValue</summary>
        public const String EHE0052 = NS + "EHE0052_ContextSampleMeasurementValue";
        /// <summary>http://purl.org/crmeh#EHE0053_ContextSampleType</summary>
        public const String EHE0053 = NS + "EHE0053_ContextSampleType";
        /// <summary>http://purl.org/crmeh#EHE0054_ContextStuffMeasurement</summary>
        public const String EHE0054 = NS + "EHE0054_ContextStuffMeasurement";
        /// <summary>http://purl.org/crmeh#EHE0055_ContextStuffMeasurementEventTimespan</summary>
        public const String EHE0055 = NS + "EHE0055_ContextStuffMeasurementEventTimespan";
        /// <summary>http://purl.org/crmeh#EHE0056_ContextStuffMeasurementEventType</summary>
        public const String EHE0056 = NS + "EHE0056_ContextStuffMeasurementEventType";
        /// <summary>http://purl.org/crmeh#EHE0057_ContextStuffMeasurementUnit</summary>
        public const String EHE0057 = NS + "EHE0057_ContextStuffMeasurementUnit";
        /// <summary>http://purl.org/crmeh#EHE0058_ContextStuffMeasurementValue</summary>
        public const String EHE0058 = NS + "EHE0058_ContextStuffMeasurementValue";
        /// <summary>http://purl.org/crmeh#EHE0059_ContextStuffNote</summary>
        public const String EHE0059 = NS + "EHE0059_ContextStuffNote";
        /// <summary>http://purl.org/crmeh#EHE0060_ContextStuffNoteType</summary>
        public const String EHE0060 = NS + "EHE0060_ContextStuffNoteType";
        /// <summary>http://purl.org/crmeh#EHE0061_ContextUID</summary>
        public const String EHE0061 = NS + "EHE0061_ContextUID";
        /// <summary>http://purl.org/crmeh#EHE0062_FlotationSample</summary>
        public const String EHE0062 = NS + "EHE0062_FlotationSample";
        /// <summary>http://purl.org/crmeh#EHE0063_FlotationSampleResidue</summary>
        public const String EHE0063 = NS + "EHE0063_FlotationSampleResidue";
        /// <summary>http://purl.org/crmeh#EHE0064_FlotationSampleResidueMeasurement</summary>
        public const String EHE0064 = NS + "EHE0064_FlotationSampleResidueMeasurement";
        /// <summary>http://purl.org/crmeh#EHE0065_FlotationSampleResidueMeasurementUnit</summary>
        public const String EHE0065 = NS + "EHE0065_FlotationSampleResidueMeasurementUnit";
        /// <summary>http://purl.org/crmeh#EHE0066_FlotationSampleResidueMeasurementValue</summary>
        public const String EHE0066 = NS + "EHE0066_FlotationSampleResidueMeasurementValue";
        /// <summary>http://purl.org/crmeh#EHE0067_FlotationSampleResidueType</summary>
        public const String EHE0067 = NS + "EHE0067_FlotationSampleResidueType";
        /// <summary>http://purl.org/crmeh#EHE0068_GroupEventRecordNote</summary>
        public const String EHE0068 = NS + "EHE0068_GroupEventRecordNote";
        /// <summary>http://purl.org/crmeh#EHE0069_GroupEventRecordNoteType</summary>
        public const String EHE0069 = NS + "EHE0069_GroupEventRecordNoteType";
        /// <summary>http://purl.org/crmeh#EHE0070_GroupEventTimespan</summary>
        public const String EHE0070 = NS + "EHE0070_GroupEventTimespan";
        /// <summary>http://purl.org/crmeh#EHE0071_GroupEventTimespanAppellation</summary>
        public const String EHE0071 = NS + "EHE0071_GroupEventTimespanAppellation";
        /// <summary>http://purl.org/crmeh#EHE0072_GroupEventType</summary>
        public const String EHE0072 = NS + "EHE0072_GroupEventType";
        /// <summary>http://purl.org/crmeh#EHE0073_GroupingPhasingProcedure</summary>
        public const String EHE0073 = NS + "EHE0073_GroupingPhasingProcedure";
        /// <summary>http://purl.org/crmeh#EHE0074_IdentifiedFeature</summary>
        public const String EHE0074 = NS + "EHE0074_IdentifiedFeature";
        /// <summary>http://purl.org/crmeh#EHE0075_IdentifiedFeatureDepiction</summary>
        public const String EHE0075 = NS + "EHE0075_IdentifiedFeatureDepiction";
        /// <summary>http://purl.org/crmeh#EHE0076_ProjectDesign</summary>
        public const String EHE0076 = NS + "EHE0076_ProjectDesign";
        /// <summary>http://purl.org/crmeh#EHE0077_ProjectTeamMember</summary>
        public const String EHE0077 = NS + "EHE0077_ProjectTeamMember";
        /// <summary>http://purl.org/crmeh#EHE0078_ProjectTeamMemberRole</summary>
        public const String EHE0078 = NS + "EHE0078_ProjectTeamMemberRole";
        /// <summary>http://purl.org/crmeh#EHE0079_RecordDrawingNote</summary>
        public const String EHE0079 = NS + "EHE0079_RecordDrawingNote";
        /// <summary>http://purl.org/crmeh#EHE0080_RecordDrawingNoteType</summary>
        public const String EHE0080 = NS + "EHE0080_RecordDrawingNoteType";
        /// <summary>http://purl.org/crmeh#EHE0081_RecordDrawingReferenceType</summary>
        public const String EHE0081 = NS + "EHE0081_RecordDrawingReferenceType";
        /// <summary>http://purl.org/crmeh#EHE0082_RecordDrawingSheet</summary>
        public const String EHE0082 = NS + "EHE0082_RecordDrawingSheet";
        /// <summary>http://purl.org/crmeh#EHE0083_RecordPhotographNote</summary>
        public const String EHE0083 = NS + "EHE0083_RecordPhotographNote";
        /// <summary>http://purl.org/crmeh#EHE0084_RecordPhotographNoteType</summary>
        public const String EHE0084 = NS + "EHE0084_RecordPhotographNoteType";
        /// <summary>http://purl.org/crmeh#EHE0085_RecordPhotographReferenceType</summary>
        public const String EHE0085 = NS + "EHE0085_RecordPhotographReferenceType";
        /// <summary>http://purl.org/crmeh#EHE0086_ResponsibleAgent</summary>
        public const String EHE0086 = NS + "EHE0086_ResponsibleAgent";
        /// <summary>http://purl.org/crmeh#EHE0087_SiteSubDivisionAppellation</summary>
        public const String EHE0087 = NS + "EHE0087_SiteSubDivisionAppellation";
        /// <summary>http://purl.org/crmeh#EHE0088_SiteSubDivisionDepiction</summary>
        public const String EHE0088 = NS + "EHE0088_SiteSubDivisionDepiction";
        /// <summary>http://purl.org/crmeh#EHE0089_StorageLocation</summary>
        public const String EHE0089 = NS + "EHE0089_StorageLocation";
        /// <summary>http://purl.org/crmeh#EHE0090_SurveyDataset</summary>
        public const String EHE0090 = NS + "EHE0090_SurveyDataset";
        /// <summary>http://purl.org/crmeh#EHE0091_Timestamp</summary>
        public const String EHE0091 = NS + "EHE0091_Timestamp";
        /// <summary>http://purl.org/crmeh#EHE0092_GroupUID</summary>
        public const String EHE0092 = NS + "EHE0092_GroupUID";
        /// <summary>http://purl.org/crmeh#EHE0093_GroupDepiction</summary>
        public const String EHE0093 = NS + "EHE0093_GroupDepiction";
        /// <summary>http://purl.org/crmeh#EHE0094_FlotationSampleResidueMeasurementType</summary>
        public const String EHE0094 = NS + "EHE0094_FlotationSampleResidueMeasurementType";
        /// <summary>http://purl.org/crmeh#EHE0095_ContextFindProductionEventLocation</summary>
        public const String EHE0095 = NS + "EHE0095_ContextFindProductionEventLocation";
        /// <summary>http://purl.org/crmeh#EHE0096_ContextFindGeneralUse</summary>
        public const String EHE0096 = NS + "EHE0096_ContextFindGeneralUse";
        /// <summary>http://purl.org/crmeh#EHE0097_ContextFindIntendedUse</summary>
        public const String EHE0097 = NS + "EHE0097_ContextFindIntendedUse";
        /// <summary>http://purl.org/crmeh#EHE0098_ContextFindExcavationEventTimespan</summary>
        public const String EHE0098 = NS + "EHE0098_ContextFindExcavationEventTimespan";
        /// <summary>http://purl.org/crmeh#EHE0099_ContextFindUseEventTimespan</summary>
        public const String EHE0099 = NS + "EHE0099_ContextFindUseEventTimespan";
        /// <summary>http://purl.org/crmeh#EHE1001_ContextEvent</summary>
        public const String EHE1001 = NS + "EHE1001_ContextEvent";
        /// <summary>http://purl.org/crmeh#EHE1002_ContextFindProductionEvent</summary>
        public const String EHE1002 = NS + "EHE1002_ContextFindProductionEvent";
        /// <summary>http://purl.org/crmeh#EHE1003_GroupEvent</summary>
        public const String EHE1003 = NS + "EHE1003_GroupEvent";
        /// <summary>http://purl.org/crmeh#EHE1004_ContextFindDepositionEvent</summary>
        public const String EHE1004 = NS + "EHE1004_ContextFindDepositionEvent";
        /// <summary>http://purl.org/crmeh#EHE1005_ContextFindUseEvent</summary>
        public const String EHE1005 = NS + "EHE1005_ContextFindUseEvent";
        /// <summary>http://purl.org/crmeh#EHE2001_ContextExcavationEven</summary>
        public const String EHE2001 = NS + "EHE2001_ContextExcavationEvent";
        /// <summary>http://purl.org/crmeh#EHE2002_ContextFindClassificationEvent</summary>
        public const String EHE2002 = NS + "EHE2002_ContextFindClassificationEvent";
        /// <summary>http://purl.org/crmeh#EHE2003_ContextFindTreatmentEvent</summary>
        public const String EHE2003 = NS + "EHE2003_ContextFindTreatmentEvent";
        /// <summary>http://purl.org/crmeh#EHE2004_GroupingPhasingEvent</summary>
        public const String EHE2004 = NS + "EHE2004_GroupingPhasingEvent";
        /// <summary>http://purl.org/crmeh#EHE2005_ContextFindDatingEvent</summary>
        public const String EHE2005 = NS + "EHE2005_ContextFindDatingEvent";
        /// <summary>http://purl.org/crmeh#EHE2006_ContextSamplingEvent</summary>
        public const String EHE2006 = NS + "EHE2006_ContextSamplingEvent";
        /// <summary>http://purl.org/crmeh#EHE2007_SurveyEvent</summary>
        public const String EHE2007 = NS + "EHE2007_SurveyEvent";
        /// <summary>http://purl.org/crmeh#EHE2008_ProcessSurveyDatasetEvent</summary>
        public const String EHE2008 = NS + "EHE2008_ProcessSurveyDatasetEvent";
        /// <summary>http://purl.org/crmeh#EHE2009_TransferObjectEvent</summary>
        public const String EHE2009 = NS + "EHE2009_TransferObjectEvent";
        /// <summary>http://purl.org/crmeh#EHE2010_DepictionEvent</summary>
        public const String EHE2010 = NS + "EHE2010_DepictionEvent";
        /// <summary>http://purl.org/crmeh#EHE2011_BulkFindItemRemovalEvent</summary>
        public const String EHE2011 = NS + "EHE2011_BulkFindItemRemovalEvent";
        /// <summary>http://purl.org/crmeh#EHE2012_ContextFindConditionAssessmentEvent</summary>
        public const String EHE2012 = NS + "EHE2012_ContextFindConditionAssessmentEvent";
        /// <summary>http://purl.org/crmeh#EHE2013_ContextFindIdentifierAssignmentEvent</summary>
        public const String EHE2013 = NS + "EHE2013_ContextFindIdentifierAssignmentEvent";
        /// <summary>http://purl.org/crmeh#EHE2014_ContextFindUseAssessmentEvent</summary>
        public const String EHE2014 = NS + "EHE2014_ContextFindUseAssessmentEvent";
        /// <summary>http://purl.org/crmeh#EHE2015_ContextSampleProcessingEvent</summary>
        public const String EHE2015 = NS + "EHE2015_ContextSampleProcessingEvent";
        /// <summary>http://purl.org/crmeh#EHE2016_ContextStuffMeasurementEvent</summary>
        public const String EHE2016 = NS + "EHE2016_ContextStuffMeasurementEvent";
        /// <summary>http://purl.org/crmeh#EHE2017_FlotationSampleProcessingEvent</summary>
        public const String EHE2017 = NS + "EHE2017_FlotationSampleProcessingEvent";
        /// <summary>http://purl.org/crmeh#EHE2018_FlotationSampleResidueProcessingEvent</summary>
        public const String EHE2018 = NS + "EHE2018_FlotationSampleResidueProcessingEvent";
        /// <summary>http://purl.org/crmeh#EHE2019_SimpleNameAssignmentEvent</summary>
        public const String EHE2019 = NS + "EHE2019_SimpleNameAssignmentEvent";
        /// <summary>http://purl.org/crmeh#EHE2020_ContextFindMeasurementEvent</summary>
        public const String EHE2020 = NS + "EHE2020_ContextFindMeasurementEvent";
        /// <summary>http://purl.org/crmeh#EHE2021_BulkFindAssessment</summary>
        public const String EHE2021 = NS + "EHE2021_BulkFindAssessment";
        #endregion

        #region properties
        /// <summary>http://purl.org/crmeh#EHP1F_is_trace_of</summary>
        public const String EHP1F = NS + "EHP1F_is_trace_of";
        /// <summary>http://purl.org/crmeh#EHP2F_is_trace_of_type</summary>
        public const String EHP2F = NS + "EHP2F_is_trace_of_type";
        /// <summary>http://purl.org/crmeh#EHP3B_was_occupied_by</summary>
        public const String EHP3B = NS + "EHP3B_was_occupied_by"; //replaced with URI.CRM.P53i?
        /// <summary>http://purl.org/crmeh#EHP3F_occupied</summary>
        public const String EHP3F = NS + "EHP3F_occupied"; //replaced with URI.CRM.P53?
        /// <summary>http://purl.org/crmeh#EHP4B_is_depicted_by</summary>
        public const String EHP4B = NS + "EHP4B_is_depicted_by";
        /// <summary>http://purl.org/crmeh#EHP4F_depicts</summary>
        public const String EHP4F = NS + "EHP4F_depicts";
        // The following extension properties are NOT part of CRMEH
        /// <summary>http://purl.org/crmeh#EXP1F_year_min</summary>
        public const String EXP1F = NS + "EXP1F_year_min";
        /// <summary>http://purl.org/crmeh#EXP2F_year_max</summary>
        public const String EXP2F = NS + "EXP2F_year_max";
        /// <summary>http://purl.org/crmeh#EXP3F_spatial_x</summary>
        public const String EXP3F = NS + "EXP3F_spatial_x";
        /// <summary>http://purl.org/crmeh#EXP4F_spatial_y</summary>
        public const String EXP4F = NS + "EXP4F_spatial_y";
        /// <summary>http://purl.org/crmeh#EXP5F_spatial_z</summary>
        public const String EXP5F = NS + "EXP5F_spatial_z";
        /// <summary>http://purl.org/crmeh#EXP10F_is_represented_by</summary>
        public const String EXP10F = NS + "EXP10F_is_represented_by";
        #endregion      
    }   
}
