/*
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_DCTERMS
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    <script type="module">
        import {URI_DCTERMS} from "./URI_DCTERMS.js"
        console.log(URI_DCTERMS.CREATOR) | console.log(URI_DCTERMS["CREATOR"])
        # both return "http://purl.org/dc/terms/creator"
    </script>
License : https://mit-license.org
History :
10/02/2023 CFB Extracted from old script and converted to ES6 module
===============================================================================
*/ 
const NS = "http://purl.org/dc/terms/"
export const URI_DCTERMS = Object.freeze({
    // entities
    DATESCHEME: `${NS}DateScheme`,
    FORMATSCHEME: `${NS}FormatScheme`,
    IDENTIFIERSCHEME: `${NS}IdentifierScheme`,
    LANGUAGESCHEME: `${NS}LanguageScheme`,
    RELATIONSCHEME: `${NS}RelationScheme`,
    SOURCESCHEME: `${NS}SourceScheme`,
    SPATIALSCHEME: `${NS}SpatialScheme`,
    SUBJECTSCHEME: `${NS}SubjectScheme`,
    TEMPORALSCHEME: `${NS}TemporalScheme`,
    TYPESCHEME: `${NS}TypeScheme`,
    // properties 
    ABSTRACT: `${NS}abstract`,
    ACCESSRIGHTS: `${NS}accessRights`,
    ACCRUALMETHOD: `${NS}accrualMethod`,
    ACCRUALPERIODICITY: `${NS}accrualPeriodicity`,
    ACCRUALPOLICY: `${NS}accrualPolicy`,
    ALTERNATIVE: `${NS}alternative`,
    AUDIENCE: `${NS}audience`,
    AVAILABLE: `${NS}available`,
    BIBLIOGRAPHICCITATION: `${NS}bibliographicCitation`,
    CONFORMSTO: `${NS}conformsTo`,
    CONTRIBUTOR: `${NS}contributor`, 
    COVERAGE: `${NS}coverage`, 
    CREATED: `${NS}created`,
    CREATOR: `${NS}creator`, 
    DATE: `${NS}date`, 
    DATEACCEPTED: `${NS}dateAccepted`,
    DATECOPYRIGHTED: `${NS}dateCopyrighted`,
    DATESUBMITTED: `${NS}dateSubmitted`,
    DESCRIPTION: `${NS}description`, 
    EDUCATIONLEVEL: `${NS}educationLevel`,
    EXTENT: `${NS}extent`,
    FORMAT: `${NS}format`, 
    HASFORMAT: `${NS}hasFormat`,
    HASPART: `${NS}hasPart`,
    HASVERSION: `${NS}hasVersion`,
    IDENTIFIER: `${NS}identifier`,
    INSTRUCTIONALMETHOD: `${NS}instructionalMethod`,
    ISFORMATOF: `${NS}isFormatOf`,
    ISPARTOF: `${NS}isPartOf`,
    ISREFERENCEDBY: `${NS}isReferencedBy`,
    ISREPLACEDBY: `${NS}isReplacedBy`,
    ISREQUIREDBY: `${NS}isRequiredBy`,
    ISSUED: `${NS}issued`,
    ISVERSIONOF: `${NS}isVersionOf`,
    LANGUAGE: `${NS}language`, 
    LICENSE: `${NS}license`,
    MEDIATOR: `${NS}mediator`,
    MEDIUM: `${NS}medium`,
    MODIFIED: `${NS}modified`,
    PROVENANCE: `${NS}provenance`,
    PUBLISHER: `${NS}publisher`,
    REFERENCES: `${NS}references`,
    RELATION: `${NS}relation`,
    REPLACES: `${NS}replaces`,
    REQUIRES: `${NS}requires`,
    RIGHTS: `${NS}rights`,
    RIGHTSHOLDER: `${NS}rightsHolder`,
    SOURCE: `${NS}source`, //new
    SPATIAL: `${NS}spatial`,
    SUBJECT: `${NS}subject`,
    TABLEOFCONTENTS: `${NS}tableOfContents`,
    TEMPORAL: `${NS}temporal`,
    TITLE: `${NS}title`,
    TYPE: `${NS}type`,
    VALID: `${NS}valid`,
    // Vocabulary Encoding Schemes
    DCMITYPE: `${NS}DCMIType`,
    DDC: `${NS}DDC`,
    IMT: `${NS}IMT`,
    LCC: `${NS}LCC`,
    LCSH: `${NS}LCSH`,
    MESH: `${NS}MESH`,
    NLM: `${NS}NLM`,
    TGN: `${NS}TGN`,
    UDC: `${NS}UDC`,
    // Syntax Encoding Schemes
    BOX: `${NS}Box`,
    ISO3166: `${NS}ISO3166`,
    ISO6392: `${NS}ISO639-2`,
    ISO6393: `${NS}ISO639-3`,
    PERIOD: `${NS}Period`,
    POINT: `${NS}Point`,
    RFC1766: `${NS}RFC1766`,
    RFC3066: `${NS}RFC3066`,
    RFC4646: `${NS}RFC4646`,
    RFC5646: `${NS}RFC5646`,
    URI: `${NS}URI`,
    W3CDTF: `${NS}W3CDTF`
})