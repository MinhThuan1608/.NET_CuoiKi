﻿/*
<<<<<<< HEAD
 Copyright (c) 2003-2022, CKSource Holding sp. z o.o. All rights reserved.
 For licensing, see LICENSE.md or https://ckeditor.com/legal/ckeditor-oss-license
*/
CKEDITOR.plugins.setLang("a11yhelp","ro",{title:"Instrucțiuni Accesibilitate",contents:"Cuprins. Pentru a închide acest dialog, apăsați tasta ESC.",legend:[{name:"General",items:[{name:"Editor bară de instrumente.",legend:"Apasă ${toolbarFocus} pentru a naviga pe de instrumente. Pentru deplasarea la următorul sau anteriorul grup de instrumente se folosesc tastele TAB și SHIFT+TAB. Pentru deplasare pe urmatorul sau anteriorul instrument se folosesc tastele SĂGEATĂ DREAPTA sau SĂGEATĂ STÂNGA. Tasta SPAȚIU sau ENTER activează instrumentul."},
{name:"Dialog editor",legend:"În interiorul unui dialog, se apasă TAB pentru navigarea la următorul element de dialog, SHIFT+TAB pentru deplasarea la anteriorul element de dialog, ENTER pentru validare dialog, ESC pentru anulare dialog. Când un dialog are secțiuni multiple, lista secțiunilor este accesibilă cu ALT+F10 sau cu TAB ca parte a ordonării secționării dialogului. Cu lista secțiunii activată, deplasarea înainte înapoi se face cu tastele SĂGEATĂ DREAPTA și respectiv STÂNGA."},{name:"Editor meniu contextual",
legend:"Apasă ${contextMenu} sau TASTA MENIU pentru a deschide meniul contextual. Se trece la următoarea opțiune din meniu cu TAB sau SĂGEATĂ JOS. La opțiunea anterioară cu SHIFT+TAB sau SĂGEATĂ SUS. Se apasă SPAȚIU sau ENTER pentru a selecta opțiunea. Deschide sub-meniul opțiunii curente cu SPAȚIU sau ENTER sau SĂGEATĂ DREAPTA. Se revine la elementul din meniul părinte cu ESC sau SĂGEATĂ STÂNGA. Închide meniul de context cu ESC."},{name:"Caseta listă a editorului",legend:"În interiorul unei liste, treci la următorull element cu TAB sau SĂGEATĂ JOS. Treci la elementul anterior din listă cu SHIFT+TAB sau SĂGEATĂ SUS. Apasă SPAȚIU sau ENTER pentru a selecta opțiunea din listă. Apasă ESC pentru a închide lista."},
{name:"Bara căii editorului de elemente",legend:"Apasă ${elementsPathFocus} pentru navigare pe elementele barei. Mergi la următorul buton cu TAB sau SĂGEATĂ JOS. Treci la butonul anterior din listă cu SHIFT+TAB sau SĂGEATĂ SUS. Apasă SPAȚIU sau ENTER pentru a selecta butonul în editor."}]},{name:"Comenzi",items:[{name:"Revino anterior (Undo)",legend:"Apasă ${undo}"},{name:"Comanda precedentă",legend:"Apasă ${redo}"},{name:"Îngroșat (Bold)",legend:"Apasă ${bold}"},{name:"Înclinat (Italic)",legend:"Apasă ${italic}"},
{name:"Subliniere (Underline)",legend:"Apasă ${underline}"},{name:"Legatură (Link)",legend:"Apasă ${link}"},{name:"Desfășurare Bară instrumente",legend:"Apasă ${toolbarCollapse}"},{name:"Accesare spațiu focus anterior",legend:"Apasă ${accessPreviousSpace} pentru a accesa cel mai apropiat spațiu focus indisponibil înaintea cursorului, de exemplu: 2 elemente adiacente HR. Repetă combinația de taste pentru a accesa spațiile îndepărtate de focus."},{name:"Accesare spațiu focus următor",legend:"Apasă ${accessNextSpace} pentru a accesa cel mai apropiat spațiu focus indisponibil după cursor, de exemplu: 2 elemente adiacente HR. Repetă combinația de taste pentru a accesa spațiile îndepărtate de focus."},
{name:"Ajutor Accesibilitate",legend:"Apasă ${a11yHelp}"},{name:"Adaugă ca Text simplu (Plain Text)",legend:"Apasă ${pastetext}",legendEdge:"Apasă ${pastetext}, urmat de ${paste}"}]}],tab:"TAB",pause:"Pauză",capslock:"Majuscule",escape:"Esc - renunță",pageUp:"Pagină sus",pageDown:"Săgeată jos",leftArrow:"Săgeată stânga",upArrow:"Săgeată sus",rightArrow:"Săgeată dreapta",downArrow:"Săgeată jos",insert:"Inserează",leftWindowKey:"Windows stânga",rightWindowKey:"Windows dreapta",selectKey:"Tasta Selecție",
numpad0:"0 Numeric",numpad1:"1 Numeric",numpad2:"2 Numeric",numpad3:"3 Numeric",numpad4:"4 Numeric",numpad5:"5 Numeric",numpad6:"6 Numeric",numpad7:"7 Numeric",numpad8:"8 Numeric",numpad9:"9 Numeric",multiply:"Înmulțire",add:"Adunare",subtract:"Scădere",decimalPoint:"Punct zecimal",divide:"Împărțire",f1:"F1",f2:"F2",f3:"F3",f4:"F4",f5:"F5",f6:"F6",f7:"F7",f8:"F8",f9:"F9",f10:"F10",f11:"F11",f12:"F12",numLock:"NumLock",scrollLock:"Scroll Lock",semiColon:"Punct și virgulă",equalSign:"Egal",comma:"Virgulă",
dash:"Linie",period:"Punct",forwardSlash:"Slash",graveAccent:"Accent grav",openBracket:"Paranteză dreaptă stânga",backSlash:"Backslash",closeBracket:"Paranteză dreaptă dreapta",singleQuote:"Ghilimea simplă"});
=======
 Copyright (c) 2003-2017, CKSource - Frederico Knabben. All rights reserved.
 For licensing, see LICENSE.md or http://ckeditor.com/license
*/
CKEDITOR.plugins.setLang("a11yhelp","ro",{title:"Instrucțiuni de accesibilitate",contents:"Cuprins. Pentru a închide acest dialog, apăsați tasta ESC.",legend:[{name:"General",items:[{name:"Editează bara instrumente.",legend:"Apasă ${toolbarFocus} pentru a naviga prin bara de instrumente. Pentru a te mișca prin grupurile de instrumente folosește tastele TAB și SHIFT+TAB. Pentru a te mișca intre diverse instrumente folosește tastele SĂGEATĂ DREAPTA sau SĂGEATĂ STÂNGA. Apasă butonul SPAȚIU sau ENTER pentru activarea instrumentului."},
{name:"Dialog editor",legend:"Inside a dialog, press TAB to navigate to the next dialog element, press SHIFT+TAB to move to the previous dialog element, press ENTER to submit the dialog, press ESC to cancel the dialog. When a dialog has multiple tabs, the tab list can be reached either with ALT+F10 or with TAB as part of the dialog tabbing order. With tab list focused, move to the next and previous tab with RIGHT and LEFT ARROW, respectively."},{name:"Editor meniu contextual",legend:"Apasă ${contextMenu} sau TASTA MENIU pentru a deschide meniul contextual. Treci la următoarea opțiune din meniu cu TAB sau SĂGEATĂ JOS. Treci la opțiunea anterioară cu  SHIFT+TAB sau SĂGEATĂ SUS. Apasă SPAȚIU sau ENTER pentru a selecta opțiunea din meniu. Deschide sub-meniul opțiunii curente cu SPAȚIU sau ENTER sau SĂGEATĂ DREAPTA. Revino la elementul din meniul părinte cu ESC sau SĂGEATĂ STÂNGA. Închide meniul de context cu ESC."},
{name:"Editor Casetă Listă",legend:"În interiorul unei liste, treci la următorull element cu TAB sau SĂGEATĂ JOS. Treci la elementul anterior din listă cu SHIFT+TAB sau SĂGEATĂ SUS. Apasă SPAȚIU sau ENTER pentru a selecta opțiunea din listă. Apasă ESC pentru a închide lista."},{name:"Editor Element Path Bar",legend:"Press ${elementsPathFocus} to navigate to the elements path bar. Move to next element button with TAB or RIGHT ARROW. Move to previous button with SHIFT+TAB or LEFT ARROW. Press SPACE or ENTER to select the element in editor."}]},
{name:"Comenzi",items:[{name:" Undo command",legend:"Apasă ${undo}"},{name:"Comanda precedentă",legend:"Apasă ${redo}"},{name:"Comanda Îngroșat",legend:"Apasă ${bold}"},{name:"Comanda Inclinat",legend:"Apasă ${italic}"},{name:"Comanda Subliniere",legend:"Apasă ${underline}"},{name:"Comanda Legatură",legend:"Apasă ${link}"},{name:" Toolbar Collapse command",legend:"Press ${toolbarCollapse}"},{name:" Access previous focus space command",legend:"Press ${accessPreviousSpace} to access the closest unreachable focus space before the caret, for example: two adjacent HR elements. Repeat the key combination to reach distant focus spaces."},
{name:" Access next focus space command",legend:"Press ${accessNextSpace} to access the closest unreachable focus space after the caret, for example: two adjacent HR elements. Repeat the key combination to reach distant focus spaces."},{name:" Accessibility Help",legend:"Press ${a11yHelp}"}]}],tab:"Tab",pause:"Pause",capslock:"Caps Lock",escape:"Escape",pageUp:"Page Up",pageDown:"Page Down",leftArrow:"Left Arrow",upArrow:"Up Arrow",rightArrow:"Right Arrow",downArrow:"Down Arrow",insert:"Insert",leftWindowKey:"Left Windows key",
rightWindowKey:"Right Windows key",selectKey:"Select key",numpad0:"Numpad 0",numpad1:"Numpad 1",numpad2:"Numpad 2",numpad3:"Numpad 3",numpad4:"Numpad 4",numpad5:"Numpad 5",numpad6:"Numpad 6",numpad7:"Numpad 7",numpad8:"Numpad 8",numpad9:"Numpad 9",multiply:"Multiply",add:"Add",subtract:"Subtract",decimalPoint:"Decimal Point",divide:"Divide",f1:"F1",f2:"F2",f3:"F3",f4:"F4",f5:"F5",f6:"F6",f7:"F7",f8:"F8",f9:"F9",f10:"F10",f11:"F11",f12:"F12",numLock:"Num Lock",scrollLock:"Scroll Lock",semiColon:"Semicolon",
equalSign:"Equal Sign",comma:"Comma",dash:"Dash",period:"Period",forwardSlash:"Forward Slash",graveAccent:"Grave Accent",openBracket:"Open Bracket",backSlash:"Backslash",closeBracket:"Close Bracket",singleQuote:"Single Quote"});
>>>>>>> 450fb9a9247746df93bf4fad4efd5624ee361aeb
