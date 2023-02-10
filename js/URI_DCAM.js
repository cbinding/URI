/*
===============================================================================
Creator : Ceri Binding, University of South Wales | Prifysgol de Cymru 
Contact : ceri.binding@southwales.ac.uk
Project : Any
Classes : URI_DCAM 
Summary : Case-sensitive entity & property URI constants (for RDF apps) 
Example : 
    <script type="module">
        import {URI_DCAM} from "./URI_DCAM.js"
        console.log(URI_DCAM.MEMBEROF) | console.log(URI_DCAM["MEMBEROF"])
        # both return "http://purl.org/dc/dcam/memberOf"
    </script>
License : https://mit-license.org
History :
10/02/2023 CFB Extracted from old script and converted to ES6 module
===============================================================================
*/
const NS = "http://purl.org/dc/dcam/"
export const URI_DCAM = Object.freeze({
    // entities
    VOCABULARYENCODINGSCHEME: `${NS}VocabularyEncodingScheme`,
    // properties
    MEMBEROF: `${NS}memberOf`
})