/**
 * @license Copyright (c) 2003-2018, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function( config ) {
	// Define changes to default configuration here. For example:
	// config.language = 'fr';
	// config.uiColor = '#AADC6E';

    
    config.syntaxhighlight_lang = 'csharp';
    config.syntaxhighlight_hideControls = true;
    config.language = 'vi';
    config.filebrowserBrowseUrl = '/Assest/admin/js/Plus-in/ckfinder/ckfinder.html';
    config.filebrowserImageBrowseUrl = '/Assest/admin/js/Plus-in/ckfinder.html?Type=Images';
    config.filebrowserFlashBrowseUrl = '/Assest/admin/js/Plus-in/ckfinder.html?Type=Flash';
    config.filebrowserUploadUrl = '/Assest/admin/js/Plus-in/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Files';
    config.filebrowserImageUploadUrl = '/Data';
    config.filebrowserFlashUploadUrl = '/Assest/admin/js/Plus-in/ckfinder/core/connector/aspx/connector.aspx?command=QuickUpload&type=Flash';

    CKFinder.setupCKEditor(null,'/Assest/admin/js/Plus-in/ckfinder/')
};
