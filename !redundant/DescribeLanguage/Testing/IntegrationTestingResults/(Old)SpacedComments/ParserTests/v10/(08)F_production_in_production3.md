========================================
Source Code (between the arrows)
========================================

🡆macronutrients <oVs6tsnU> ->

    water <9Y9uFDwu>,
	fiber <PALnQoTQ>[http://testlink.com/] ->

        what [http://testlink.com/]<6hlYVfaz>,
        not [http://testlink.com/]<gubSBEDe>;

	somth else [http://testlink.com/]<hAyLdw3m>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'macronutrients ')
│   │   └── T(TAG|'<oVs6tsnU> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'water ')
│   │   │   │   └── T(TAG|'<9Y9uFDwu>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   └── expression
│   │   │       ├── item
│   │   │       │   ├── text_chunk
│   │   │       │   │   └── T(DATA|'fiber ')
│   │   │       │   ├── T(TAG|'<PALnQoTQ>')
│   │   │       │   └── T(LINK|'[http://testlink.com/] ')
│   │   │       ├── producer
│   │   │       │   ├── T(HYPHEN|'-')
│   │   │       │   └── T(PRODUCTION_ARROW|'>\r\n\r\n        ')
│   │   │       ├── item_or_expression_list
│   │   │       │   ├── item_or_expression_part
│   │   │       │   │   ├── item
│   │   │       │   │   │   ├── text_chunk
│   │   │       │   │   │   │   └── T(DATA|'what ')
│   │   │       │   │   │   ├── T(LINK|'[http://testlink.com/]')
│   │   │       │   │   │   └── T(TAG|'<6hlYVfaz>')
│   │   │       │   │   └── T(SEPARATOR|',\r\n        ')
│   │   │       │   └── item
│   │   │       │       ├── text_chunk
│   │   │       │       │   └── T(DATA|'not ')
│   │   │       │       ├── T(LINK|'[http://testlink.com/]')
│   │   │       │       └── T(TAG|'<gubSBEDe>')
│   │   │       └── T(TERMINATOR|';\r\n\r\n\t')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'somth else ')
│   │       ├── T(LINK|'[http://testlink.com/]')
│   │       └── T(TAG|'<hAyLdw3m>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')