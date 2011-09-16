#!/usr/bin/env python
#############################
# Module:   URI_DCTERMS.py
# Author:   C Binding
# Date:     2008-07-09
# Version:  Draft 0.1
'''
Module defines URI constants for DCTERMS RDF entities and properties
'''
###############################
# Log:
# 2008-07-09    CFB - Initially created module
################################

NS_DCTERMS = "http://purl.org/dc/terms/"    
#Entity types
SUBJECTSCHEME = NS_DCTERMS + "SubjectScheme"
DATESCHEME = NS_DCTERMS + "DateScheme"
FORMATSCHEME = NS_DCTERMS + "FormatScheme"
LANGUAGESCHEME = NS_DCTERMS + "LanguageScheme"
SPATIALSCHEME = NS_DCTERMS + "SpatialScheme"
TEMPORALSCHEME = NS_DCTERMS + "TemporalScheme"
TYPESCHEME = NS_DCTERMS + "TypeScheme"
IDENTIFIERSCHEME = NS_DCTERMS + "IdentifierScheme"
RELATIONSCHEME = NS_DCTERMS + "RelationScheme"
SOURCESCHEME = NS_DCTERMS + "SourceScheme"
#Property types
TITLE = NS_DCTERMS + "title"
AUDIENCE = NS_DCTERMS + "audience"
ALTERNATIVE = NS_DCTERMS + "alternative"
TABLEOFCONTENTS = NS_DCTERMS + "tableOfContents"
ABSTRACT = NS_DCTERMS + "abstract"
CREATED = NS_DCTERMS + "created"
VALID = NS_DCTERMS + "valid"
AVAILABLE = NS_DCTERMS + "available"
ISSUED = NS_DCTERMS + "issued"
MODIFIED = NS_DCTERMS + "modified"
EXTENT = NS_DCTERMS + "extent"
MEDIUM = NS_DCTERMS + "medium"
ISVERSIONOF = NS_DCTERMS + "isVersionOf"
HASVERSION = NS_DCTERMS + "hasVersion"
ISREPLACEDBY = NS_DCTERMS + "isReplacedBy"
REPLACES = NS_DCTERMS + "replaces"
ISREQUIREDBY = NS_DCTERMS + "isRequiredBy"
REQUIRES = NS_DCTERMS + "requires"
ISPARTOF = NS_DCTERMS + "isPartOf"
HASPART = NS_DCTERMS + "hasPart"
ISREFERENCEDBY = NS_DCTERMS + "isReferencedBy"
REFERENCES = NS_DCTERMS + "references"
ISFORMATOF = NS_DCTERMS + "isFormatOf"
HASFORMAT = NS_DCTERMS + "hasFormat"
CONFORMSTO = NS_DCTERMS + "conformsTo"
SPATIAL = NS_DCTERMS + "spatial"
TEMPORAL = NS_DCTERMS + "temporal"
MEDIATOR = NS_DCTERMS + "mediator"
DATEACCEPTED = NS_DCTERMS + "dateAccepted"
DATECOPYRIGHTED = NS_DCTERMS + "dateCopyrighted"
DATESUBMITTED = NS_DCTERMS + "dateSubmitted"
EDUCATIONLEVEL = NS_DCTERMS + "educationLevel"
ACCESSRIGHTS = NS_DCTERMS + "accessRights"
BIBLIOGRAPHICCITATION = NS_DCTERMS + "bibliographicCitation"
LICENSE = NS_DCTERMS + "license"
RIGHTSHOLDER = NS_DCTERMS + "rightsHolder"
PROVENANCE = NS_DCTERMS + "provenance"
INSTRUCTIONALMETHOD = NS_DCTERMS + "instructionalMethod"
ACCRUALMETHOD = NS_DCTERMS + "accrualMethod"
ACCRUALPERIODICITY = NS_DCTERMS + "accrualPeriodicity"
ACCRUALPOLICY = NS_DCTERMS + "accrualPolicy"

TITLE = NS_DCTERMS + "title"
CREATOR = NS_DCTERMS + "creator"
SUBJECT = NS_DCTERMS + "subject"
DESCRIPTION = NS_DCTERMS + "description"
PUBLISHER = NS_DCTERMS + "publisher"
CONTRIBUTOR = NS_DCTERMS + "contributor"
DATE = NS_DCTERMS + "date"
TYPE = NS_DCTERMS + "type"
FORMAT = NS_DCTERMS + "format"
IDENTIFIER = NS_DCTERMS + "identifier"
SOURCE = NS_DCTERMS + "source"
LANGUAGE = NS_DCTERMS + "language"
RELATION = NS_DCTERMS + "relation"
COVERAGE = NS_DCTERMS + "coverage"
RIGHTS = NS_DCTERMS + "rights"