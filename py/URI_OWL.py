#!/usr/bin/env python
#############################
# Module:   URI_OWL.py
# Author:   C Binding
# Date:     2008-07-09
# Version:  Draft 0.1
'''
Module defines URI constants for OWL entities and properties
'''
###############################
# Log:
# 2008-07-09    CFB - Initially created module
################################

NS_OWL = "http://www.w3.org/2002/07/owl#"    
#Entity types
ALLDIFFERENT = NS_OWL + "AllDifferent"
ANNOTATIONPROPERTY = NS_OWL + "AnnotationProperty"
CLASS = NS_OWL + "Class"
DATARANGE = NS_OWL + "DataRange"
DATATYPEPROPERTY = NS_OWL + "DatatypeProperty"
DEPRECATEDCLASS = NS_OWL + "DeprecatedClass"
DEPRECATEDPROPERTY = NS_OWL + "DeprecatedProperty"
FUNCTIONALPROPERTY = NS_OWL + "FunctionalProperty"
INVERSEFUNCTIONALPROPERTY = NS_OWL + "InverseFunctionalProperty"
NOTHING = NS_OWL + "Nothing"
OBJECTPROPERTY = NS_OWL + "ObjectProperty"
ONTOLOGY = NS_OWL + "Ontology"
ONTOLOGYPROPERTY = NS_OWL + "OntologyProperty"
RESTRICTION = NS_OWL + "Restriction"
SYMMETRICPROPERTY = NS_OWL + "SymmetricProperty"
THING = NS_OWL + "Thing"
TRANSITIVEPROPERTY = NS_OWL + "TransitiveProperty"
#Property types
ALLVALUESFROM = NS_OWL + "allValuesFrom"
BACKWARDCOMPATIBLEWITH = NS_OWL + "backwardCompatibleWith"
CARDINALITY = NS_OWL + "cardinality"
COMPLEMENTOF = NS_OWL + "complementOf"
DIFFERENTFROM = NS_OWL + "differentFrom"
DISJOINTWITH = NS_OWL + "disjointWith"
DISTINCTMEMBERS = NS_OWL + "distinctMembers"
EQUIVALENTCLASS = NS_OWL + "equivalentClass"
EQUIVALENTPROPERTY = NS_OWL + "equivalentProperty"
HASVALUE = NS_OWL + "hasValue"
IMPORTS = NS_OWL + "imports"
INCOMPATIBLEWITH = NS_OWL + "incompatibleWith"
INTERSECTIONOF = NS_OWL + "intersectionOf"
INVERSEOF = NS_OWL + "inverseOf"
MAXCARDINALITY = NS_OWL + "maxCardinality"
MINCARDINALITY = NS_OWL + "minCardinality"
ONEOF = NS_OWL + "oneOf"
ONPROPERTY = NS_OWL + "onProperty"
PRIORVERSION = NS_OWL + "priorVersion"
SAMEAS = NS_OWL + "sameAs"
SOMEVALUESFROM = NS_OWL + "someValuesFrom"
UNIONOF = NS_OWL + "unionOf"
VERSIONINFO = NS_OWL + "versionInfo"