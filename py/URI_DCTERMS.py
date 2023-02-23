"""
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_DCTERMS
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    import URI_DCTERMS
    print(URI_DCTERMS.TITLE) # "http://purl.org/dc/terms/title"
License : https://mit-license.org
History :
23/02/2023 CFB Extracted from old script, updated to use F-strings
===============================================================================
"""
# Namespace
NS = "http://purl.org/dc/terms/"

# Entities
SUBJECTSCHEME = f"{NS}SubjectScheme"
DATESCHEME = f"{NS}DateScheme"
FORMATSCHEME = f"{NS}FormatScheme"
LANGUAGESCHEME = f"{NS}LanguageScheme"
SPATIALSCHEME = f"{NS}SpatialScheme"
TEMPORALSCHEME = f"{NS}TemporalScheme"
TYPESCHEME = f"{NS}TypeScheme"
IDENTIFIERSCHEME = f"{NS}IdentifierScheme"
RELATIONSCHEME = f"{NS}RelationScheme"
SOURCESCHEME = f"{NS}SourceScheme"

# Properties
TITLE = f"{NS}title"
AUDIENCE = f"{NS}audience"
ALTERNATIVE = f"{NS}alternative"
TABLEOFCONTENTS = f"{NS}tableOfContents"
ABSTRACT = f"{NS}abstract"
CREATED = f"{NS}created"
VALID = f"{NS}valid"
AVAILABLE = f"{NS}available"
ISSUED = f"{NS}issued"
MODIFIED = f"{NS}modified"
EXTENT = f"{NS}extent"
MEDIUM = f"{NS}medium"
ISVERSIONOF = f"{NS}isVersionOf"
HASVERSION = f"{NS}hasVersion"
ISREPLACEDBY = f"{NS}isReplacedBy"
REPLACES = f"{NS}replaces"
ISREQUIREDBY = f"{NS}isRequiredBy"
REQUIRES = f"{NS}requires"
ISPARTOF = f"{NS}isPartOf"
HASPART = f"{NS}hasPart"
ISREFERENCEDBY = f"{NS}isReferencedBy"
REFERENCES = f"{NS}references"
ISFORMATOF = f"{NS}isFormatOf"
HASFORMAT = f"{NS}hasFormat"
CONFORMSTO = f"{NS}conformsTo"
SPATIAL = f"{NS}spatial"
TEMPORAL = f"{NS}temporal"
MEDIATOR = f"{NS}mediator"
DATEACCEPTED = f"{NS}dateAccepted"
DATECOPYRIGHTED = f"{NS}dateCopyrighted"
DATESUBMITTED = f"{NS}dateSubmitted"
EDUCATIONLEVEL = f"{NS}educationLevel"
ACCESSRIGHTS = f"{NS}accessRights"
BIBLIOGRAPHICCITATION = f"{NS}bibliographicCitation"
LICENSE = f"{NS}license"
RIGHTSHOLDER = f"{NS}rightsHolder"
PROVENANCE = f"{NS}provenance"
INSTRUCTIONALMETHOD = f"{NS}instructionalMethod"
ACCRUALMETHOD = f"{NS}accrualMethod"
ACCRUALPERIODICITY = f"{NS}accrualPeriodicity"
ACCRUALPOLICY = f"{NS}accrualPolicy"
TITLE = f"{NS}title"
CREATOR = f"{NS}creator"
SUBJECT = f"{NS}subject"
DESCRIPTION = f"{NS}description"
PUBLISHER = f"{NS}publisher"
CONTRIBUTOR = f"{NS}contributor"
DATE = f"{NS}date"
TYPE = f"{NS}type"
FORMAT = f"{NS}format"
IDENTIFIER = f"{NS}identifier"
SOURCE = f"{NS}source"
LANGUAGE = f"{NS}language"
RELATION = f"{NS}relation"
COVERAGE = f"{NS}coverage"
RIGHTS = f"{NS}rights"
