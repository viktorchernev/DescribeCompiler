The DescribeTranslator is the abstract base class for all the translators.

	1. IsInitialized - This is meant as a failsafe - if false then the translation process should not be allowed to start.
	2. TranslateUnfold(DescribeUnfold) - Translate an unfold structure. This is the main method.



	DescribeTranslator

		.bool													IsInitialized
		.TranslateUnfold(DescribeUnfold)		->string