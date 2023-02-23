"""
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_OWL
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    import URI_OWL
    print(URI_OWL.CLASS) # " http://www.w3.org/2002/07/owl#Class"
License : https://mit-license.org
History :
23/02/2023 CFB Extracted from old script, updated to use F-strings
===============================================================================
"""
# Namespace
NS = "http://www.w3.org/2002/07/owl#"

# Entities
ALLDIFFERENT = f"{NS}AllDifferent"
ANNOTATIONPROPERTY = f"{NS}AnnotationProperty"
CLASS = f"{NS}Class"
DATARANGE = f"{NS}DataRange"
DATATYPEPROPERTY = f"{NS}DatatypeProperty"
DEPRECATEDCLASS = f"{NS}DeprecatedClass"
DEPRECATEDPROPERTY = f"{NS}DeprecatedProperty"
FUNCTIONALPROPERTY = f"{NS}FunctionalProperty"
INVERSEFUNCTIONALPROPERTY = f"{NS}InverseFunctionalProperty"
NOTHING = f"{NS}Nothing"
OBJECTPROPERTY = f"{NS}ObjectProperty"
ONTOLOGY = f"{NS}Ontology"
ONTOLOGYPROPERTY = f"{NS}OntologyProperty"
RESTRICTION = f"{NS}Restriction"
SYMMETRICPROPERTY = f"{NS}SymmetricProperty"
THING = f"{NS}Thing"
TRANSITIVEPROPERTY = f"{NS}TransitiveProperty"

# Properties
ALLVALUESFROM = f"{NS}allValuesFrom"
BACKWARDCOMPATIBLEWITH = f"{NS}backwardCompatibleWith"
CARDINALITY = f"{NS}cardinality"
COMPLEMENTOF = f"{NS}complementOf"
DIFFERENTFROM = f"{NS}differentFrom"
DISJOINTWITH = f"{NS}disjointWith"
DISTINCTMEMBERS = f"{NS}distinctMembers"
EQUIVALENTCLASS = f"{NS}equivalentClass"
EQUIVALENTPROPERTY = f"{NS}equivalentProperty"
HASVALUE = f"{NS}hasValue"
IMPORTS = f"{NS}imports"
INCOMPATIBLEWITH = f"{NS}incompatibleWith"
INTERSECTIONOF = f"{NS}intersectionOf"
INVERSEOF = f"{NS}inverseOf"
MAXCARDINALITY = f"{NS}maxCardinality"
MINCARDINALITY = f"{NS}minCardinality"
ONEOF = f"{NS}oneOf"
ONPROPERTY = f"{NS}onProperty"
PRIORVERSION = f"{NS}priorVersion"
SAMEAS = f"{NS}sameAs"
SOMEVALUESFROM = f"{NS}someValuesFrom"
UNIONOF = f"{NS}unionOf"
VERSIONINFO = f"{NS}versionInfo"
