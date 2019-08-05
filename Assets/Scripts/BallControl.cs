using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{ 
   
    public float movementSped = 15f;
    public float rotateSped = 10f;
    public Joystick joystickMove;
    public Joystick joystickRotate;
    public GameObject sphere;
    public Vector2 vecc;
    public Vector3 rotation;
    private CharacterController characterController;
    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        Rotation();
       

    }
   
    void movement()
    {
        vecc = new Vector2(joystickMove.Horizontal, joystickMove.Vertical);
        vecc = transform.TransformDirection(vecc);
        vecc *= movementSped;

        characterController.Move(vecc * Time.deltaTime);
    }
    void Rotation()
    {
       transform.rotation *= Quaternion.Euler(0, 0, joystickRotate.Horizontal*rotateSped);
       


    }

}
//                                            .,codddddddo:'.                                         
//                                        .';codxxkkkkkkkkkxl;.                                       
//                                     .':odxxkkOOO000000000Okxl,.                                    
//                                    .:odxxkkO000KKKKKKKKKKK00kxo;.                                  
//                                   .codxkkO000KKKKKKKXXXKKKK00Okxl'                                 
//                                  .;ldxkkOO00KKKKKKKXXXXXXXKKK0OOxo,                                
//                                 ,cdxkkOO000KKKXXXXXXXXXXXXXKK00Oxl'                               
//                                 .:dxkkOOOO00KKKXXXXXNNXXXXXXKKK0Okdc.
//                                 .lxxkkkkOO00KKKKXXXXXXXXXXXKK000Okxd:.                             
//                                 .lxxkkkkO000KKKKKXXXXXXXKKKK0000OOkxl'                             
//                                  ;ddxkOOOO0000KKKKXXXXXXK00000000Okxl'                             
//                                .'cdddxkOkkkdoodxO00KKXXK00000000OOxl;.                             
//                               .cdodxddkOOko:ccc::::coxOOkkkkkxdolc;...                             
//                               .okdoodxxO0Oxxxdol:,,;;:loxOOko:,..''',.                             
//                               .lkkdodxxkO00OkxxxdodkkkOO0KKOddxololcl;.                            
//                                'xOkdxxdxO000000KKKKKKKKK00KOxk000Okxo:.                            
//                                .lkxxkkddkOOOO0KKKKKKKKK000K0kxkOOOkxl;.                            
//                                 ;xxxkkxxkOOOO0KKKKK0OkOOO0K0OdoxOOOxl;.                            
//                                 ,dxxkOkkkkkOO00OkxkkkkOOk0KKOxoxkkkko:'                            
//                             .''..;oxkOOkkkkkOkxkkOO00xddoxOOxl:oxxddc,.                            
//                            .;:::;:odkOOkkkkkkxxdxxkOOOkxoc:;;;codddoc;.                            
//                           .::ccc:coxxkOkOOkkkkxollccodxkOkxol:::cxkdl:.                            
//                        ..';:::cc::oxkkkOOOOOkkkkkkxodddddool:;:cdkxdl'                             
//                    ..';cllc::::cc:lxkkkkOOOOOOkkkkxddxkkxdddlccodxdl,                              
//                ..';:clllllc::::ccc:okkOOOOOOO0OOkkkxddxxddolc:lxxl:'                               
//            ..';:::::clllcc::cc:cclccoxkOOOOOOOOOOOkxdddoollccoxxl'                                 
//        ...,;::::::cccccccc:;::::ccccloxkkO00OOkkOOOOkkkxxddodxo;.                                  
//    ..',,;;;;;;::::::ccc::;;,'......':looxkkOOOkxkkkkkkxxxxxddc'  ....''..                          
//  ..',,,,,,;;;;;::;::::::;'.....'',,'':cloodxxkkxxddddoodoolc,.  .',,,,,,,.                         
//..'''',,',,,;:;;;;;;;::;,..';:ccccc::,..,:lllllodollc::;;,'..  .''',,,''','.                        
//....'',''',,,;;;;;;;;;:,',::::::::::::;'.,clcc::::::;;;,'..  ..,,,,,''...'''..                      
//.....'''''',,,,;;,,,,;;;;;;;::;::::::;::;'',;:ccc::;,'....',;c:;,,,,.. .''''''.                     
//.......''.''''',,,,,,,,,,,,,;;;;;;;;;;;;;,''...';cclc::;:loool:;,,,'...'''''''..                    
//............'''',',,,,,,,,,,,,,,,,,,,,,,;;,,,''...';::ccloooolc;,,,'.''''''......   
//      .,clloooooooolc:;cdxxdxkkkkOOkkkxdooodoodxxdxxxkkkkxxkkkOOOO000OOOOkkkkxxkkkkkOkkkkkkOOkxdddoolllc:::ccl:;::clllll:;:clooddddoooodxxxxkkkkO0000KKKKKKKKKKKKKKKKKKKKKKKKKKKKXXXXXKKKKKKKKKKK0000000000000OOO0OO0000OOO00000KK0KKKKKK0000000000000OOOO000OOO00000OOOOOkkOOkkkkkkkkkxxdoololc:;,,'..''',,'..''.        
//    .,clooooxxdddddxxxxddddxkkxkkkkkkkkxdolcclodxxxxxxxxxkkxxkkOOO000OOOOkkkxkkkOkkkOkkkkkxkkxdddoollc:::;,;;;,,,;;::,,,,;;::::cccclol:clloddxxkOO0OOOOO000000KK00KKKKKKKKKKKKKKKKKKKKKKKKKKKKK00000000000000OOO0OOOOOOOOOOO00000K000K00000000O0000OOOOOO0000OOOO00OOOOkkkkkkkkxxkxxxxdddollc:cccc:;'..',,,,,,;,'..       
//   .:loooooodddxxxxkkkxdddxxxxxxxxkkkkkxolc::clodxxdxxdxxkkxxkOOO00000OOOOOkkkxkkkkOOOkkkkkkxxxxxoc:cc:;;;,'.....',''.'',,,,,',,,;,,;,',codxdoodxddoodddxkkOOO0000KK00KKKKKKK000KKK00KKKKKKKKKK0000000O000O00OOOOOOOOOOOOOOOO0000000000000000OO0000OOOOOOOOOOOOOOOOOOkkkkkOOOkkkkkxxxxdolc:,,''',,;:,,,'....''.....       
//  .:oooodddddddxxxkOOOkkxdddxxxxxxxxkkkxdo:;cccoodxddxxxxxkkxkkOO0OO00OOOOOkkkxxxkkkkkxxxkOkkxdoc,'';:;'.'',,,,,,,,,,,'',:c;'''',,;:,',cdollc::clodllddxxxxxkOOO000000KKKKK00000KKK0000KKKKK0000000000000OO00000OOOOOOOOOOOkOOO00O000000000OOOO00000OOOOkOOkkkOOkkkOOkkOOOOkkxxxxxxdxdddoc:;,''...............','..       
// .;lddddooooolooodxO00OxocldkkxxdddxkkOkxol:;:cdxdddddxxxdxxxxkOO0OO00OOOOOkOkkxxxkkkkxxxxxddolcc;,,;;;,'..'''',,'.......,:;;:c:;''....';cc::;,;:ldlclooddoooodxkkxxkOO0KKK00000KK00K0KKK00000000000000000O00OOOOOOOOOOOOOOkkkOOOO00000OOOOOOOOOOO0OOOOOOOOkkkkkOOOOOOOOOOOOkxxdollcc:::;,''..... .....''......',...      
// .coxxxdol:;,,,;:coxkOOkdoloxxxdxxxxkOkkxxdllodxxddoddxxdodxkkkOOOO0000OOOkkOOOkkxkkkkkxxddlc::;,'',,,,,,,,,,,',;;;,''....','.'''''......''',,;;;;;;',;:clldoccllodxkkxxkO00OOOkkOO0KKKK00000000000000000OOOOOOOOOOOOOOOkkkxxxkkkOOO0OOOOOOOOOkkkOOOkkkkOOOkkkkkkkkkkkkkkkOOOkxdl:::;,,'''........'..''.....    ...       
// 'codxxdlc;,''....,:okkkxxddxxddxkkkkOkkkxdddddxdddoodxxxddxxxxkOOO000000OkkkOOkkxxkkkkkxxddlc:;,'',;;;;;;;:ccc::cccc:;;,',;:;;,'''''...........'',;,',;,,;:::ll:;:ldxxkxdxkkxxxxxk000000O00000OOOO00000OOOOOkkOOOOOOOOOkxxxxxkkkkkOOOOOOOOkkkkkxxxxxkkkkkkkkxdxxxxxxddolooloolcc,',''',;,.''',,.',.....         .        
// ,lodxddlllool:;,'.',cdxxxdoloddxkkkkkkkkxddddkkkxddddxxxdddxxxkkOO00OO0000Okkkkkkkkkkxkxxdolcc::;;;:::cccccllcllllooddolcccc::::;,''..''........''..',.,::,,'',:c::clooxdodOOxddddxO0000OO00OkkkOOkkkOOOOOOkkOkkOkkkOOOkxxxkkxxxkkkkkOOOOkkkkxxxxxxxxxxdddddooddddoll;,::;::,,:;,;'..,c:,''''''....             .        
//.,lddxxdddxkkxdolc:,.';lodddlloodxkkkkkkxdooxkkkxdxxdddxxxddddxxkOOOOOOO0000OOkkkkkkkxxxxxdolcccc:;::ccllooooooooooodxxxxddolcccc::;,''...............'''''';,..,::::cc:cc:coxkxdddddkkOOOkkkxxkkkkkkkkkxxkkkkkkkkkkkkkxkxxdxxxxxkkkkkkkkxxxxxdoooodddollllllccccc::cc;;clccccll;::,;cc;,'.........    .....     .  .     
//.;odxkkxxkOOOkxddddoc,',:ldxdllloxkkkxxxdlldxdoodddxxxxxxxxddddxxkkOOkkO00000000OOOOkkxxxdl:::;;::::cclooddoooodddddddddxxdddddollc:;,,'''..''..........',..',...'',:c:::;,,:clddooooxkxkkOkkOOOkkxxxdxxxxkxkkkkkkkkkkxxxxxoddxxxxxxxxxxxdddooololllcc::::;,,;:::;;::,',;;;;cl:,,;cc;'......       ..........  .   ..     
// ,oxkkkkkOOOOkxdxxkkxo:',:lddoloxkkxxxxdocloooodoloxxxxxxxxxdddxxxkkOkOO000000000Okkkxxxxxolcc::ccccllooooodxxddddddxxkkkkkkkxxxxdddooolc::;;,''.........''...'.....',,,,',;,;:cloddoldkxkOOkkxdoooodddddxxxxkkkxxkkxxxxxxxoodddxxdddxdoooooollllllc:;;;;,'''.''','.....,;;:;'..''.....'.... ..  .............   ..       
// ,lxkkkkkOOOOxddxkkOOOxl;,:odddodxkkkxddoccllodooddxxkkkxxxxxddxddxkkOO0000000000OOOOkxxxkxddddddooollodddddxxxxdxxxxkkkkkkkxxxxxxxxkkOOkxxdddooc:;'......''...''....'.''..,;,,;:lodolldxxkxxxooollllodddxxxxxxdddxxxkkkkxxdolodxxdoododddddolcccc:::;,,,''''..',...  ...'............... .........,;;,''....   ...       
// ,oxkkOkkOOOkxddxkOO00Oko:;cooolloxxxxdooooodddodxxxxkkxxkkkxxxxxxxkkkkO00000KKK000OOOkkkkxdddoooodddddddxxxkkkkxdddxxxxxxkkxxdoddodddxxxkkkkkkkkkxdlc:;,'',,,''.',''...''''''',;;:cloolodxdollcc:::cooddddddddoxkkkkkkkkxxdlcoxkxxdddddddddolcc:;,;;,,'....''''.     ........   ..........',,''';:cc;,'''...     ..      
// ,oxkkOOOOOOkdodxkkO0000ko:,;cllloddxxdoooodddoodxxxxkkkkkkkxkkxxxxxkkkkOOO00KKK0000OOkkkxxxxxxxdddddddxxxxkkOOkkkxdddddxxxxdoollllooooooooddxkkkxxxddoc::;;;;;,'',,,,...'''...',;;;:cccloolcccc:::clloooooddxxkOO0OOOOOkkkkxddxkkkkxdddolllc::;,''',,,,,,'''....   ....................',;;;:;::ccc:;,,''...     ..      
//.;dkOOOOOOOkxddxxkkOO000Oxl;;:cllclxkkxdooddoooddddddxxxkkkkkkkkxxxkkkkkOOOO0KKK00000OOOOkkkkkkkxxxxxxxkkkkxkkkOOkxdoooolllllloddxxxxxxxxxxkOOOkkkkxddoll:;;;;;,,,,'''''','''.''''',;,;:::cc::;;:ccloooddddxxkkO0KK00000OOOOOkxxkkkkkdoollc:;,,,'...........................................',;;;;;;;;;,'....      ..     
//.:dkO00OOOOkdoddxkkkkkOOkxdc,',:llcldxdddooodddddddodxkxxxxkkkOOOOkkkkkkOOOOkO00000000OOOOOkkkkkkkkkkkkxkkkkxxxkkxxdolllllodddddxxxdddddddolooooolllooooolcc::;,''.''',;::;;;;;,,,'',,,;;;:::;;::ccloodxkkkkO00OO0000OOOOkkkxkkkOOkkkxoolc:;,''............'''....................',,,,,,,,,,,;;::ccl:;,'........   .     
//.;dkO00OOOOxoodxxxkkkxxxxxdoc;,;;;,;looooodxxdooodddddxxxkxxkkkOOOO0OOOOOOOOkkO000000OOOOOOOOOkkkkxxxxxxxkkkxdddddddooodddddooooooolllc:;;,'''''.........''',;,,,,,''''',,;:cclllc:;;;;;;;:::::clldxkOOO000KKKKK0OOOOOkkxxxxxkkkOOOOkxol:;,'......'',,,,,,,''... ..      .............',,,,,,',:clooc;;;,'.''........     
//.;oxkO0OOOkxoodddxxkkkkOkkxdo:'..';cooooodxxddddxxxxxxddxxdxkkkOOOOO0OOO00OOOOOOOO000OOOOOOkxkkkkxxxxxxxxxxxxdxxxxxxxddddollcccc:;,,,,.....................';c:;,,,,,,;;;;;;;:clooolcccclccccllodxkO0000KKKXXXXXKK00OOOOxdddxkOOOOOOkxdl:,''',,,;;;:::;,'...     ..      ...',;,,''............';:::;;;;,,,,'.........    
// ,oxkO0OOOkdodxxxkkkkkkkkkxdl:'.':loooooddxdddxxxxxxxkxxxdodkkkOOOOOkkk000000000OOOOOOOOkOOOkkkkkkkkkxxxxxkxxkkkOOOOxocc:;,'',''.'';cc,''..............,;cdOkxdol:;,,;;::c::::cllllloooddoooodxkkOO000KKKXXXXXXXKK000OOkkkkOOOOOkkkxoc,,:cllllc::;;,'...   ..      .......;clllllc;.........',;;;,;;;;:ccc:,,,....      
// 'oxOOOOOOxoodxkkkkkkkkkxxdlc;..:odl:ldddxxdodddoooxxxxxxddxkkkkkkkOkkkOOOOOO000000000OOkkkOOkOOOOOOkkkkxxkkkkkkOO0Okol:;'';;;:::cloddl;,,,'...........',:lx0KK00OOxoccc:ccccllcccclodxkkkxxxxddxkkOO00KKKKKKXXXNXXXXXK00OO0000OOOkkxdl;;cloolc:,'',;;:;'''''...........',,;cdxdoooc:,'''......,;::;;::clollc:,'...       
// .lxOO0OOkdodxxkkkkkkkkkxdolc;,;codccooooooddddolldxxkxxxxxxxxxkkkkkOkkkkkOOOO00000000K000000000OOOkkkkkkxxxxxkkkkkkxdoolclddodxxxxkkOkocc:;,'..',,..',;:lk0KKKK0OOkxddoollooodddooodk0KK0OkkkkkxkkOO00KKKKKKXXXXXXXXXXKKKKKKK00OOkxdoc:lool:,'.',;lxxkxoc;;;,''......',,;;cdkkkkkdlccclll:'..,;:cc:cloddooll:,''...      
// .cxkO00OkdodxkkkkOOkkkkkxxdl::;,:odddoloddxkdoooddxxxxxxxxxxxxxkkkkkOOkkkOOOOOOOO0000KKKKKKKKKXKK00OOOOkkxxxxkkkxxxxxxxxxxkxxkOOkkOO00OOkxxdoooodolloooxO000OOOOOkxkkkkxkkOOO0O00Okxxk0KK0OkOOOOkkOOO00KKKKKKKXXXXXXXXKKKKKKK0OOOkxdl:lddoc:clooddxxkkkkxdll::cc;'',,,;;:lxkkkkkkxddxxddol:,',;cloolodooollc;'','...     
// .:dkO00OkoodkkkOOOOOOOOOkkxoc:;,cxkxooodxkxdlcododkxdxxxxxxxxkkkkkkkkOOOOOO0000OO00KKKKKKKKKKXXXKKKKKKK00OOkxxxkxdxOOOkkkkkkOOOOOO0OOOOOOOkO000K00000OO00OOOOkOOkxxxkkOOOOO0000KKK0K0O0K00OOO000OOOO0000KKKKKKKXXXXKKKKKKKKK000OOkxolcoxkdodkOOOOkkOOkkkkkOkkkOOxoololodxkOOkkkkkkkxxdoolc:;;;;:cllllllllcc:,',,,....    
//  ,dkO00OxoodkkkOOOOOOOOkkxdoolc:dkxddxdooddolcoddxxxddxxxxxxxxxkkkkkOOkkOOOO000000KKKKKKKKKKKKKKKKK00000OOkkxxxxddxO00OOOOOOOO00000000000Ok0000KK0000K000O00OkOOkkkkkOOOOOO00KKKXKKXXXKK00OOO00000OOO0000KKKKKKKKKXKKKKKKK000000OkxolloxkxdkOOOOOOOO0OO0000KK0OO00OOOOkkkxkkkxxdddddddoolccccccloolcccclooolc::;,..      
//  .cxO00OkooxkkOOOO00OOOkxxddxxdodddddoooodxocldxddxxdddddxxxxxxkkkkkOkxxkkOOOO00000KKKKKKKKKKKKKKK00KK0000OOOOOkkxkO0K00OO00000000KKK00KK00KK0KKXKKKKKKOO000OO00000000000000000KKKKKKKK00000000000OOOO00000KKKKKKXXKKKKKK0000000OkxoloddxkkOO00000000KKKKKKKK0OO0Okkkkxxxddxxdodddddxxddoooodooodddoooddxxddol:;,'..     
//   ,okO00kooxkOO0OOOOOO0OkkkkkOkolooooodddooooddddddxddddxxxxxxxxkkkkkkkkkOOOO000000KKKKKKKKKKKKKKKKKKKK0000000000OkkO00000000KKKKKKKK00000KKKXXXXXXKKKXKKKKK000000KKKKKK0000000000KKKKK0KKKKKKK0000OOO00OO00KKKKKKK0KKKK0000000OOkxoloddxkkOO0KKXXKKXXNNNNNNXK0000OOOkkkkxxkxddxkkxxxxxxxddxkxdoodxxdodddxddoc:,'....    
//   .:dkO0kooxkO000000000OOOkO00kdoddxxolooodxxxxdxxxxxxdddxddxxxxdodxkkkOOOO000000KKKKKKKKKKKKKKKKKKKKK00K0000000OOOkxxxkkO000KKKKKKKKKKKKKKXXXXXXNNXXXXXXXKKKKKKKKKKKKKKKK0000KKKKKKKKKKKKKKKKKKK000OOOOOO0000KKK000KK00000000OOkkdooodxxkkOO000KXKKXXNNNNNXNXXXKKK00000OOOOOkkkkkkkkkkkkkkkkkxdoodddddxxdddoc;,'.....   
//    'lxkOkodkOO000000000OOOOO00kdxdxkddoldxdodkxxkkxxkxxddxxdxxxdolodkkkkOO0000000KKKKKK00KKKKKK00KKKK0000000OOOOOOOOOkxxkkkkOO0KKKKKKKXKKKKKKKKKKXXKKKKKKKKKKKKKKKKKK0000KKKKKXXKKKKKKKKKKKKKKKKKK00OOOOOOO000KKK000KK0000OOOOOOkkxdoodxxxkOOO000KKKKXXNXXXXXXXXKKKKKKK0000000OOOOOOkkkkkkkkkkxddollodxxxdool:;'.......  
//    .;dkOkddkO0000000000000000OkkxddxodoldxolodkkkkxxxxxxdxddxxxdolodxkkOO00000000000K000KKKKKKKK0000OO0000000OOO0000000000000OOOO00000KKK000000000K00KKKKKKKK00000KKKKKKKKXXXXXXKKKKKKKKKKKKKKKKKK00OOOOOOOOO000KKKKKKK00000OOOOkxxdoodxxxkOOOO000000KKXXXXXXXXXKKKKKKKK00000000OOOOOkkOkkkkkxdolllllloxxdoolc;'..       
//     .cxkkodkO00KK0000000000000OxkdloddddxxoloodkOOkxxkxxxdddddddoodxxkkOOO0000000OO00000KKKKK000O00OOO0000000000O000000000KKKKKKKKKKKK00KKKKKKKKKKKKKKKKKKKKKK0KKKKKKKXXXXXXXKKKKKKKKKKKKKKKKK000000OOOOOOOO000000000KKKK0000000OkxdooodxxkOOOOOO000000KKKKXXXKKKKKK0000000000OOOOOOOkkkxxxdollcllodolllodddolc,..       
//      'lxkdoxO00KKK00000000000K0kkxodxxxxdxddxddxxkkkxxxxxddoooddodddxxkOOOO0OOO0000000000000000000OOOO00000000000000OOOOOOOOO00000KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKXXXXXXXXKKKKKKKKKKXXXKKKKK0000000OOOOOOOO00000000KKKKKKK00000OkxdoodxxkkOOOOOOOOOOOO000KKKKK000K0000000OOOOkkkkkkkkxxdollodddddddollllloolc;,,'..    
//       ,dkxodO000K00000000OOO00OkxxxdxkkdddddxdxdxxxkkxxxxxdooooooodddxxkOOOOOOO00000000000000000OOOOOOO00OO000000000000000OOOO000000000000KK000KK000OOO00KKKKKKKXXXXXXXKKKKKXXXKKXXKXXKKKKKKKK000000OOOOOOOO0000000KKKKKKKKKK000OOkxdolodxxkOO0OOOOOOOOOOO00000000000000OOOOOkkkkkkxxxdddddxkkkxxdddddollccllc::,,,,.    
//       .:dxooxO00000000000OkOOOOxxkkkkkxxxxxkxxxddddxdxxxxxxddooooooddxkkOOOOOOOO000000OOOO000OOOOOOOOO000OO0OO0000000000KKK00KKKKKKKKKKKKKXXXXXXXXKK000KKKKKXXXXXXXXXXKKKKKKKKKKKKXXXKKKKKKKKKK00000OOOOOOOOOOO000KKKKKKKKKKKK00OOOkxdooddxxkOOOOOOOOOOOOOOO0OOOOOOOOOOOOOOkkkkkkkxxdddxxkkOOkkxxdddooolllccllc:;,''..   
//        'oxdodkO0000000OOkxdxxxxdoooxdooxxkOkxxxxxkxddkkxxxxdddoolooodxkkOOOOOO000OOOOOOkOO000OOOkOOOO0000OO0000000000KKKKKKK0KKKKKKKKKKKKKXXXXXXXXXKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKXKKKKKKKKKK00000OOOOOOOOOO00000KKKKKXXXKKKXK0OOOOkxdoloxxxkkkkOOOOOOOOOOOkOOOOOOOOOOkkkkkkkkxxxxxkkOO000Okxxxxdddoollllccclc:;,''.    
//        .:xkdldkOO00000Okxdoooodo:;lddook0OkkkkxxxOxoxkOkkkxxddooolooodxkOOOOOOOOOOOO00000000OOOOOOOO0000OOOO00000000000KKKKKKKKKKKKKKKKKKKKKKXXXXKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK00000OOOOOOOOOO00000KKKKKKKKKK00KK00OOOkxdolldxxxkkkkOkkkkOOOOOOOOOOOOOOOkkxxxxkxxxkkkkkOOOOOOOkxxxdxdddoolllccccc:;',,'.   


