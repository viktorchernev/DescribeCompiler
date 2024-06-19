========================================
Source Code (between the arrows)
========================================

🡆macronutrients [http://testlink.com/]<eQxYylc3> ->

    water <tdgS8qBO>,
	fiber <OpdFntBx> ->

        what [http://testlink.com/]<MLUxjdg8>,
        not <qkVgxZIs>;
;
🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'macronutrients ')
│   │   ├── T(LINK|'[http://testlink.com/]')
│   │   └── T(TAG|'<eQxYylc3> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water ')
│   │   │   │   └── T(TAG|'<tdgS8qBO>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── expression
│   │       ├── item
│   │       │   ├── text_chunk
│   │       │   │   └── T(DATA|'fiber ')
│   │       │   └── T(TAG|'<OpdFntBx> ')
│   │       ├── producer
│   │       │   ├── T(HYPHEN|'-')
│   │       │   └── T(PRODUCTION_ARROW|'>\r\n\r\n        ')
│   │       ├── item_or_expression_list
│   │       │   ├── item_or_expression_part
│   │       │   │   ├── item
│   │       │   │   │   ├── text_chunk
│   │       │   │   │   │   └── T(DATA|'what ')
│   │       │   │   │   ├── T(LINK|'[http://testlink.com/]')
│   │       │   │   │   └── T(TAG|'<MLUxjdg8>')
│   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │       │   └── item
│   │       │       ├── text_chunk
│   │       │       │   └── T(DATA|'not ')
│   │       │       └── T(TAG|'<qkVgxZIs>')
│   │       └── T(TERMINATOR|';\n')
│   └── T(TERMINATOR|';\n')
└── T(EOF|'<EOF>')