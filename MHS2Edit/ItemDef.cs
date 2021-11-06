using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHS2Edit
{
    class ItemDef
    {
        public static Dictionary<uint, string> Names = new Dictionary<uint, string>
        {
            // 0x00 -> 0xFF Healing
             {  000, "<NONE>" }
            ,{  001, "Herb" }
            ,{  002, "Potion" }
            ,{  003, "Mega Potion" }
            ,{  004, "Lifesoot" }
            ,{  005, "Lifepowder" }
            ,{  006, "__UNKNOWN__" }
            ,{  007, "__UNKNOWN__" }
            ,{  008, "__UNKNOWN__" }
            ,{  009, "Immunizer" }
            ,{  010, "Antidote Herb" }
            ,{  011, "Antidote" }
            ,{  012, "Aloe Leaf" }
            ,{  013, "Burn Ointment" }
            ,{  014, "__UNKNOWN__" }
            ,{  015, "__UNKNOWN__" }
            ,{  016, "__UNKNOWN__" }
            ,{  017, "Energy Drink" }
            ,{  018, "Girthy Garlic" }
            ,{  019, "Zest Pill" }
            ,{  020, "__UNKNOWN__" }
            ,{  021, "__UNKNOWN__" }
            ,{  022, "Vital Essence" }
            ,{  023, "__UNKNOWN__" }
            ,{  024, "__UNKNOWN__" }
            ,{  025, "__UNKNOWN__" }
            ,{  026, "__UNKNOWN__" }
            ,{  027, "__UNKNOWN__" }
            ,{  028, "Hot Mist" }
            ,{  029, "Mahana Dunker" }
            ,{  030, "__UNKNOWN__" }
            ,{  031, "Rutoh Ringer" }
            ,{  032, "__UNKNOWN__" }
            ,{  033, "__UNKNOWN__" }
            ,{  034, "__UNKNOWN__" }
            ,{  035, "__UNKNOWN__" }
            ,{  036, "__UNKNOWN__" }
            ,{  037, "__UNKNOWN__" }
            ,{  038, "__UNKNOWN__" }
            ,{  039, "__UNKNOWN__" }
            ,{  040, "__UNKNOWN__" }
            ,{  041, "__UNKNOWN__" }
            ,{  042, "__UNKNOWN__" }
            ,{  043, "__UNKNOWN__" }
            ,{  044, "__UNKNOWN__" }
            ,{  045, "__UNKNOWN__" }
            ,{  046, "Whetstone" }
            ,{  047, "Super Whetstone" }
            ,{  048, "__UNKNOWN__" }
            ,{  049, "__UNKNOWN__" }
            ,{  050, "__UNKNOWN__" }
            ,{  051, "__UNKNOWN__" }
            ,{  052, "__UNKNOWN__" }
            ,{  053, "__UNKNOWN__" }
            ,{  054, "__UNKNOWN__" }
            ,{  055, "__UNKNOWN__" }
            ,{  056, "__UNKNOWN__" }
            ,{  057, "__UNKNOWN__" }
            ,{  058, "__UNKNOWN__" }
            ,{  059, "__UNKNOWN__" }
            ,{  060, "__UNKNOWN__" }
            ,{  061, "__UNKNOWN__" }
            ,{  062, "__UNKNOWN__" }
            ,{  063, "__UNKNOWN__" }
            ,{  064, "__UNKNOWN__" }
            ,{  065, "__UNKNOWN__" }
            ,{  066, "__UNKNOWN__" }
            ,{  067, "__UNKNOWN__" }
            ,{  068, "__UNKNOWN__" }
            ,{  069, "__UNKNOWN__" }
            ,{  070, "__UNKNOWN__" }
            ,{  071, "__UNKNOWN__" }
            ,{  072, "__UNKNOWN__" }
            ,{  073, "__UNKNOWN__" }
            ,{  074, "__UNKNOWN__" }
            ,{  075, "__UNKNOWN__" }
            ,{  076, "__UNKNOWN__" }
            ,{  077, "__UNKNOWN__" }
            ,{  078, "__UNKNOWN__" }
            ,{  079, "__UNKNOWN__" }
            ,{  080, "__UNKNOWN__" }
            ,{  081, "__UNKNOWN__" }
            ,{  082, "__UNKNOWN__" }
            ,{  083, "__UNKNOWN__" }
            ,{  084, "__UNKNOWN__" }
            ,{  085, "__UNKNOWN__" }
            ,{  086, "__UNKNOWN__" }
            ,{  087, "__UNKNOWN__" }
            ,{  088, "__UNKNOWN__" }
            ,{  089, "__UNKNOWN__" }
            ,{  090, "__UNKNOWN__" }
            ,{  091, "__UNKNOWN__" }
            ,{  092, "__UNKNOWN__" }
            ,{  093, "__UNKNOWN__" }
            ,{  094, "__UNKNOWN__" }
            ,{  095, "__UNKNOWN__" }
            ,{  096, "__UNKNOWN__" }
            ,{  097, "__UNKNOWN__" }
            ,{  098, "__UNKNOWN__" }
            ,{  099, "__UNKNOWN__" }
            ,{  100, "__UNKNOWN__" }
            ,{  101, "__UNKNOWN__" }
            ,{  102, "__UNKNOWN__" }
            ,{  103, "__UNKNOWN__" }
            ,{  104, "__UNKNOWN__" }
            ,{  105, "__UNKNOWN__" }
            ,{  106, "__UNKNOWN__" }
            ,{  107, "__UNKNOWN__" }
            ,{  108, "__UNKNOWN__" }
            ,{  109, "__UNKNOWN__" }
            ,{  110, "__UNKNOWN__" }
            ,{  111, "__UNKNOWN__" }
            ,{  112, "__UNKNOWN__" }
            ,{  113, "__UNKNOWN__" }
            ,{  114, "__UNKNOWN__" }
            ,{  115, "__UNKNOWN__" }
            ,{  116, "__UNKNOWN__" }
            ,{  117, "__UNKNOWN__" }
            ,{  118, "Flash Bomb" }
            ,{  119, "Sonic Bomb" }
            ,{  120, "Poison Knife" }
            ,{  121, "__UNKNOWN__" }
            ,{  122, "Sleep Knife" }
            ,{  123, "Throwing Knife" }
            ,{  124, "__UNKNOWN__" }
            ,{  125, "__UNKNOWN__" }
            ,{  126, "__UNKNOWN__" }
            ,{  127, "__UNKNOWN__" }
            ,{  128, "__UNKNOWN__" }
            ,{  129, "Stone" }
            ,{  130, "__UNKNOWN__" }
            ,{  131, "__UNKNOWN__" }
            ,{  132, "__UNKNOWN__" }
            ,{  133, "__UNKNOWN__" }
            ,{  134, "__UNKNOWN__" }
            ,{  135, "__UNKNOWN__" }
            ,{  136, "__UNKNOWN__" }
            ,{  137, "__UNKNOWN__" }
            ,{  138, "__UNKNOWN__" }
            ,{  139, "__UNKNOWN__" }
            ,{  140, "Paintball" }
            ,{  141, "__UNKNOWN__" }
            ,{  142, "__UNKNOWN__" }
            ,{  143, "__UNKNOWN__" }
            ,{  144, "__UNKNOWN__" }
            ,{  145, "Tranq Trap" }
            ,{  146, "Big Barrel Bomb" }
            ,{  147, "__UNKNOWN__" }
            ,{  148, "__UNKNOWN__" }
            ,{  149, "__UNKNOWN__" }
            ,{  150, "__UNKNOWN__" }
            ,{  151, "__UNKNOWN__" }
            ,{  152, "__UNKNOWN__" }
            ,{  153, "__UNKNOWN__" }
            ,{  154, "__UNKNOWN__" }
            ,{  155, "__UNKNOWN__" }
            ,{  156, "__UNKNOWN__" }
            ,{  157, "__UNKNOWN__" }
            ,{  158, "__UNKNOWN__" }
            ,{  159, "Vitality Nutriment" }
            ,{  160, "Strength Nutriment" }
            ,{  161, "Defense Nutriment" }
            ,{  162, "__UNKNOWN__" }
            ,{  163, "__UNKNOWN__" }
            ,{  164, "__UNKNOWN__" }
            ,{  165, "__UNKNOWN__" }
            ,{  166, "__UNKNOWN__" }
            ,{  167, "__UNKNOWN__" }
            ,{  168, "__UNKNOWN__" }
            ,{  169, "__UNKNOWN__" }
            ,{  170, "__UNKNOWN__" }
            ,{  171, "__UNKNOWN__" }
            ,{  172, "__UNKNOWN__" }
            ,{  173, "__UNKNOWN__" }
            ,{  174, "__UNKNOWN__" }
            ,{  175, "__UNKNOWN__" }
            ,{  176, "Well-Done Steak" }
            ,{  177, "__UNKNOWN__" }
            ,{  178, "__UNKNOWN__" }
            ,{  179, "__UNKNOWN__" }
            ,{  180, "__UNKNOWN__" }
            ,{  181, "__UNKNOWN__" }
            ,{  182, "Stable Blueprint" }
            ,{  183, "Stable Blueprint 2" }
            ,{  184, "__UNKNOWN__" }
            ,{  185, "__UNKNOWN__" }
            ,{  186, "__UNKNOWN__" }
            ,{  187, "__UNKNOWN__" }
            ,{  188, "__UNKNOWN__" }
            ,{  189, "__UNKNOWN__" }
            ,{  190, "__UNKNOWN__" }
            ,{  191, "__UNKNOWN__" }
            ,{  192, "__UNKNOWN__" }
            ,{  193, "__UNKNOWN__" }
            ,{  194, "__UNKNOWN__" }
            ,{  195, "__UNKNOWN__" }
            ,{  196, "__UNKNOWN__" }
            ,{  197, "__UNKNOWN__" }
            ,{  198, "__UNKNOWN__" }
            ,{  199, "__UNKNOWN__" }

            ,{  200, "__UNKNOWN__" }
            ,{  201, "__UNKNOWN__" }
            ,{  202, "__UNKNOWN__" }
            ,{  203, "__UNKNOWN__" }
            ,{  204, "__UNKNOWN__" }
            ,{  205, "__UNKNOWN__" }
            ,{  206, "__UNKNOWN__" }
            ,{  207, "__UNKNOWN__" }
            ,{  208, "__UNKNOWN__" }
            ,{  209, "__UNKNOWN__" }
            ,{  210, "__UNKNOWN__" }
            ,{  211, "__UNKNOWN__" }
            ,{  212, "__UNKNOWN__" }
            ,{  213, "__UNKNOWN__" }
            ,{  214, "__UNKNOWN__" }
            ,{  215, "__UNKNOWN__" }
            ,{  216, "__UNKNOWN__" }
            ,{  217, "__UNKNOWN__" }
            ,{  218, "__UNKNOWN__" }
            ,{  219, "__UNKNOWN__" }
            ,{  220, "__UNKNOWN__" }
            ,{  221, "__UNKNOWN__" }
            ,{  222, "__UNKNOWN__" }
            ,{  223, "__UNKNOWN__" }
            ,{  224, "__UNKNOWN__" }
            ,{  225, "__UNKNOWN__" }
            ,{  226, "__UNKNOWN__" }
            ,{  227, "__UNKNOWN__" }
            ,{  228, "__UNKNOWN__" }
            ,{  229, "__UNKNOWN__" }
            ,{  230, "__UNKNOWN__" }
            ,{  231, "__UNKNOWN__" }
            ,{  232, "__UNKNOWN__" }
            ,{  233, "__UNKNOWN__" }
            ,{  234, "__UNKNOWN__" }
            ,{  235, "__UNKNOWN__" }
            ,{  236, "__UNKNOWN__" }
            ,{  237, "__UNKNOWN__" }
            ,{  238, "__UNKNOWN__" }
            ,{  239, "__UNKNOWN__" }
            ,{  240, "__UNKNOWN__" }
            ,{  241, "__UNKNOWN__" }
            ,{  242, "__UNKNOWN__" }
            ,{  243, "__UNKNOWN__" }
            ,{  244, "__UNKNOWN__" }
            ,{  245, "__UNKNOWN__" }
            ,{  246, "__UNKNOWN__" }
            ,{  247, "__UNKNOWN__" }
            ,{  248, "__UNKNOWN__" }
            ,{  249, "__UNKNOWN__" }
            ,{  250, "__UNKNOWN__" }
            ,{  251, "__UNKNOWN__" }
            ,{  252, "__UNKNOWN__" }
            ,{  253, "__UNKNOWN__" }
            ,{  254, "__UNKNOWN__" }
            ,{  255, "__UNKNOWN__" }
            ////////////////////////////
            //                        //
            // 0x100 -> 0x1FF Support //
            //                        //
            ////////////////////////////
            ,{  256, "__UNKNOWN__" }
            ,{  257, "__UNKNOWN__" }
            ,{  258, "__UNKNOWN__" }
            ,{  259, "__UNKNOWN__" }
            ,{  260, "__UNKNOWN__" }
            ,{  261, "__UNKNOWN__" }
            ,{  262, "__UNKNOWN__" }
            ,{  263, "__UNKNOWN__" }
            ,{  264, "__UNKNOWN__" }
            ,{  265, "__UNKNOWN__" }
            ,{  266, "__UNKNOWN__" }
            ,{  267, "__UNKNOWN__" }
            ,{  268, "__UNKNOWN__" }
            ,{  269, "__UNKNOWN__" }
            ,{  270, "__UNKNOWN__" }
            ,{  271, "__UNKNOWN__" }
            ,{  272, "__UNKNOWN__" }
            ,{  273, "__UNKNOWN__" }
            ,{  274, "__UNKNOWN__" }
            ,{  275, "__UNKNOWN__" }
            ,{  276, "__UNKNOWN__" }
            ,{  277, "__UNKNOWN__" }
            ,{  278, "Herbivore Stimulant" }
            ,{  279, "Bird Wyvern Stimulant" }
            ,{  280, "Flying Wyvern Stimulant" }
            ,{  281, "Fanged Beast Stimulant" }
            ,{  282, "__UNKNOWN__" }
            ,{  283, "__UNKNOWN__" }
            ,{  284, "Leviathan Stimulant" }
            ,{  285, "__UNKNOWN__" }
            ,{  286, "Amphibian Stimulant" }
            ,{  287, "__UNKNOWN__" }
            ,{  288, "__UNKNOWN__" }
            ,{  289, "__UNKNOWN__" }
            ,{  290, "__UNKNOWN__" }
            ,{  291, "__UNKNOWN__" }
            ,{  292, "__UNKNOWN__" }
            ,{  293, "__UNKNOWN__" }
            ,{  294, "__UNKNOWN__" }
            ,{  295, "__UNKNOWN__" }
            ,{  296, "__UNKNOWN__" }
            ,{  297, "__UNKNOWN__" }
            ,{  298, "__UNKNOWN__" }
            ,{  299, "__UNKNOWN__" }

            ,{  300, "__UNKNOWN__" }
            ,{  301, "__UNKNOWN__" }
            ,{  302, "__UNKNOWN__" }
            ,{  303, "__UNKNOWN__" }
            ,{  304, "__UNKNOWN__" }
            ,{  305, "__UNKNOWN__" }
            ,{  306, "__UNKNOWN__" }
            ,{  307, "__UNKNOWN__" }
            ,{  308, "__UNKNOWN__" }
            ,{  309, "__UNKNOWN__" }
            ,{  310, "__UNKNOWN__" }
            ,{  311, "__UNKNOWN__" }
            ,{  312, "__UNKNOWN__" }
            ,{  313, "__UNKNOWN__" }
            ,{  314, "__UNKNOWN__" }
            ,{  315, "__UNKNOWN__" }
            ,{  316, "__UNKNOWN__" }
            ,{  317, "__UNKNOWN__" }
            ,{  318, "__UNKNOWN__" }
            ,{  319, "__UNKNOWN__" }
            ,{  320, "__UNKNOWN__" }
            ,{  321, "__UNKNOWN__" }
            ,{  322, "__UNKNOWN__" }
            ,{  323, "__UNKNOWN__" }
            ,{  324, "__UNKNOWN__" }
            ,{  325, "__UNKNOWN__" }
            ,{  326, "__UNKNOWN__" }
            ,{  327, "__UNKNOWN__" }
            ,{  328, "__UNKNOWN__" }
            ,{  329, "__UNKNOWN__" }
            ,{  330, "__UNKNOWN__" }
            ,{  331, "__UNKNOWN__" }
            ,{  332, "__UNKNOWN__" }
            ,{  333, "__UNKNOWN__" }
            ,{  334, "__UNKNOWN__" }
            ,{  335, "__UNKNOWN__" }
            ,{  336, "__UNKNOWN__" }
            ,{  337, "__UNKNOWN__" }
            ,{  338, "__UNKNOWN__" }
            ,{  339, "__UNKNOWN__" }
            ,{  340, "__UNKNOWN__" }
            ,{  341, "__UNKNOWN__" }
            ,{  342, "__UNKNOWN__" }
            ,{  343, "__UNKNOWN__" }
            ,{  344, "__UNKNOWN__" }
            ,{  345, "__UNKNOWN__" }
            ,{  346, "__UNKNOWN__" }
            ,{  347, "__UNKNOWN__" }
            ,{  348, "__UNKNOWN__" }
            ,{  349, "__UNKNOWN__" }
            ,{  350, "__UNKNOWN__" }
            ,{  351, "__UNKNOWN__" }
            ,{  352, "__UNKNOWN__" }
            ,{  353, "__UNKNOWN__" }
            ,{  354, "__UNKNOWN__" }
            ,{  355, "__UNKNOWN__" }
            ,{  356, "__UNKNOWN__" }
            ,{  357, "__UNKNOWN__" }
            ,{  358, "__UNKNOWN__" }
            ,{  359, "__UNKNOWN__" }
            ,{  360, "__UNKNOWN__" }
            ,{  361, "__UNKNOWN__" }
            ,{  362, "__UNKNOWN__" }
            ,{  363, "__UNKNOWN__" }
            ,{  364, "__UNKNOWN__" }
            ,{  365, "__UNKNOWN__" }
            ,{  366, "__UNKNOWN__" }
            ,{  367, "__UNKNOWN__" }
            ,{  368, "__UNKNOWN__" }
            ,{  369, "__UNKNOWN__" }
            ,{  370, "__UNKNOWN__" }
            ,{  371, "__UNKNOWN__" }
            ,{  372, "__UNKNOWN__" }
            ,{  373, "__UNKNOWN__" }
            ,{  374, "__UNKNOWN__" }
            ,{  375, "__UNKNOWN__" }
            ,{  376, "__UNKNOWN__" }
            ,{  377, "__UNKNOWN__" }
            ,{  378, "__UNKNOWN__" }
            ,{  379, "__UNKNOWN__" }
            ,{  380, "__UNKNOWN__" }
            ,{  381, "__UNKNOWN__" }
            ,{  382, "__UNKNOWN__" }
            ,{  383, "__UNKNOWN__" }
            ,{  384, "__UNKNOWN__" }
            ,{  385, "__UNKNOWN__" }
            ,{  386, "__UNKNOWN__" }
            ,{  387, "__UNKNOWN__" }
            ,{  388, "__UNKNOWN__" }
            ,{  389, "__UNKNOWN__" }
            ,{  390, "__UNKNOWN__" }
            ,{  391, "__UNKNOWN__" }
            ,{  392, "__UNKNOWN__" }
            ,{  393, "__UNKNOWN__" }
            ,{  394, "__UNKNOWN__" }
            ,{  395, "__UNKNOWN__" }
            ,{  396, "__UNKNOWN__" }
            ,{  397, "__UNKNOWN__" }
            ,{  398, "__UNKNOWN__" }
            ,{  399, "__UNKNOWN__" }

            ,{  400, "__UNKNOWN__" }
            ,{  401, "__UNKNOWN__" }
            ,{  402, "__UNKNOWN__" }
            ,{  403, "__UNKNOWN__" }
            ,{  404, "__UNKNOWN__" }
            ,{  405, "__UNKNOWN__" }
            ,{  406, "__UNKNOWN__" }
            ,{  407, "__UNKNOWN__" }
            ,{  408, "__UNKNOWN__" }
            ,{  409, "__UNKNOWN__" }
            ,{  410, "__UNKNOWN__" }
            ,{  411, "__UNKNOWN__" }
            ,{  412, "__UNKNOWN__" }
            ,{  413, "__UNKNOWN__" }
            ,{  414, "__UNKNOWN__" }
            ,{  415, "__UNKNOWN__" }
            ,{  416, "__UNKNOWN__" }
            ,{  417, "__UNKNOWN__" }
            ,{  418, "__UNKNOWN__" }
            ,{  419, "__UNKNOWN__" }
            ,{  420, "__UNKNOWN__" }
            ,{  421, "__UNKNOWN__" }
            ,{  422, "__UNKNOWN__" }
            ,{  423, "__UNKNOWN__" }
            ,{  424, "__UNKNOWN__" }
            ,{  425, "__UNKNOWN__" }
            ,{  426, "__UNKNOWN__" }
            ,{  427, "__UNKNOWN__" }
            ,{  428, "__UNKNOWN__" }
            ,{  429, "__UNKNOWN__" }
            ,{  430, "__UNKNOWN__" }
            ,{  431, "__UNKNOWN__" }
            ,{  432, "__UNKNOWN__" }
            ,{  433, "Training Charm" }
            ,{  434, "__UNKNOWN__" }
            ,{  435, "Gathering Charm" }
            ,{  436, "Lucky Charm" }
            ,{  437, "Finding Charm" }
            ,{  438, "Mounting Charm" }
            ,{  439, "Selling Charm" }
            ,{  440, "Buying Charm" }
            ,{  441, "Adamant Charm" }
            ,{  442, "Might Charm" }
            ,{  443, "Recovery Charm" }
            ,{  444, "__UNKNOWN__" }
            ,{  445, "__UNKNOWN__" }
            ,{  446, "__UNKNOWN__" }
            ,{  447, "__UNKNOWN__" }
            ,{  448, "__UNKNOWN__" }
            ,{  449, "__UNKNOWN__" }
            ,{  450, "__UNKNOWN__" }
            ,{  451, "__UNKNOWN__" }
            ,{  452, "__UNKNOWN__" }
            ,{  453, "__UNKNOWN__" }
            ,{  454, "__UNKNOWN__" }
            ,{  455, "__UNKNOWN__" }
            ,{  456, "__UNKNOWN__" }
            ,{  457, "__UNKNOWN__" }
            ,{  458, "__UNKNOWN__" }
            ,{  459, "__UNKNOWN__" }
            ,{  460, "__UNKNOWN__" }
            ,{  461, "__UNKNOWN__" }
            ,{  462, "__UNKNOWN__" }
            ,{  463, "__UNKNOWN__" }
            ,{  464, "__UNKNOWN__" }
            ,{  465, "Unique Mushroom" }
            ,{  466, "Golden Fragment" }
            ,{  467, "Goldenfry" }
            ,{  468, "__UNKNOWN__" }
            ,{  469, "__UNKNOWN__" }
            ,{  470, "__UNKNOWN__" }
            ,{  471, "__UNKNOWN__" }
            ,{  472, "Royal Honey" }
            ,{  473, "Crimson Coral" }
            ,{  474, "__UNKNOWN__" }
            ,{  475, "Crystal Bone" }
            ,{  476, "__UNKNOWN__" }
            ,{  477, "Silver Spidersilk" }
            ,{  478, "Pittance Fang" }
            ,{  479, "__UNKNOWN__" }
            ,{  480, "__UNKNOWN__" }
            ,{  481, "__UNKNOWN__" }
            ,{  482, "__UNKNOWN__" }
            ,{  483, "Divine Rhino" }
            ,{  484, "Great Shroom" }
            ,{  485, "__UNKNOWN__" }
            ,{  486, "Diamond Dust" }
            ,{  487, "Icebound Bone" }
            ,{  488, "__UNKNOWN__" }
            ,{  489, "Golden Chunk" }
            ,{  490, "__UNKNOWN__" }
            ,{  491, "__UNKNOWN__" }
            ,{  492, "__UNKNOWN__" }
            ,{  493, "__UNKNOWN__" }
            ,{  494, "__UNKNOWN__" }
            ,{  495, "Silver Cricket" }
            ,{  496, "__UNKNOWN__" }
            ,{  497, "Bottle Cap" }
            ,{  498, "__UNKNOWN__" }
            ,{  499, "Valuable Scale" }

            ,{  500, "__UNKNOWN__" }
            ,{  501, "__UNKNOWN__" }
            ,{  502, "__UNKNOWN__" }
            ,{  503, "__UNKNOWN__" }
            ,{  504, "__UNKNOWN__" }
            ,{  505, "__UNKNOWN__" }
            ,{  506, "__UNKNOWN__" }
            ,{  507, "__UNKNOWN__" }
            ,{  508, "__UNKNOWN__" }
            ,{  509, "__UNKNOWN__" }
            ,{  510, "Trap Tool" }
            ,{  511, "__UNKNOWN__" }
            //////////////////////////////
            //                          //
            // 0x200 -> 0x2FF Materials //
            //                          //
            //////////////////////////////
            ,{  512, "__UNKNOWN__" }
            ,{  513, "__UNKNOWN__" }
            ,{  514, "Large Barrel" }
            ,{  515, "__UNKNOWN__" }
            ,{  516, "__UNKNOWN__" }
            ,{  517, "__UNKNOWN__" }
            ,{  518, "__UNKNOWN__" }
            ,{  519, "__UNKNOWN__" }
            ,{  520, "__UNKNOWN__" }
            ,{  521, "__UNKNOWN__" }
            ,{  522, "__UNKNOWN__" }
            ,{  523, "__UNKNOWN__" }
            ,{  524, "__UNKNOWN__" }
            ,{  525, "Fire Herb" }
            ,{  526, "Ivy" }
            ,{  527, "Sap Plant" }
            ,{  528, "Woemill Wheat" }
            ,{  529, "Gloamgrass Bud" }
            ,{  530, "__UNKNOWN__" }
            ,{  531, "__UNKNOWN__" }
            ,{  532, "__UNKNOWN__" }
            ,{  533, "__UNKNOWN__" }
            ,{  534, "__UNKNOWN__" }
            ,{  535, "__UNKNOWN__" }
            ,{  536, "__UNKNOWN__" }
            ,{  537, "__UNKNOWN__" }
            ,{  538, "__UNKNOWN__" }
            ,{  539, "__UNKNOWN__" }
            ,{  540, "__UNKNOWN__" }
            ,{  541, "__UNKNOWN__" }
            ,{  542, "__UNKNOWN__" }
            ,{  543, "__UNKNOWN__" }
            ,{  544, "__UNKNOWN__" }
            ,{  545, "__UNKNOWN__" }
            ,{  546, "__UNKNOWN__" }
            ,{  547, "__UNKNOWN__" }
            ,{  548, "__UNKNOWN__" }
            ,{  549, "__UNKNOWN__" }
            ,{  550, "__UNKNOWN__" }
            ,{  551, "__UNKNOWN__" }
            ,{  552, "__UNKNOWN__" }
            ,{  553, "Paintberry" }
            ,{  554, "__UNKNOWN__" }
            ,{  555, "Heftcorn" }
            ,{  556, "__UNKNOWN__" }
            ,{  557, "__UNKNOWN__" }
            ,{  558, "__UNKNOWN__" }
            ,{  559, "__UNKNOWN__" }
            ,{  560, "__UNKNOWN__" }
            ,{  561, "__UNKNOWN__" }
            ,{  562, "__UNKNOWN__" }
            ,{  563, "__UNKNOWN__" }
            ,{  564, "__UNKNOWN__" }
            ,{  565, "__UNKNOWN__" }
            ,{  566, "__UNKNOWN__" }
            ,{  567, "__UNKNOWN__" }
            ,{  568, "__UNKNOWN__" }
            ,{  569, "__UNKNOWN__" }
            ,{  570, "Blue Mushroom" }
            ,{  571, "__UNKNOWN__" }
            ,{  572, "Nitroshroom" }
            ,{  573, "King Truffle" }
            ,{  574, "__UNKNOWN__" }
            ,{  575, "Toadstool" }
            ,{  576, "Stinkshroom" }
            ,{  577, "Duskshroom" }
            ,{  578, "Chillshroom" }
            ,{  579, "__UNKNOWN__" }
            ,{  580, "__UNKNOWN__" }
            ,{  581, "__UNKNOWN__" }
            ,{  582, "__UNKNOWN__" }
            ,{  583, "__UNKNOWN__" }
            ,{  584, "__UNKNOWN__" }
            ,{  585, "__UNKNOWN__" }
            ,{  586, "__UNKNOWN__" }
            ,{  587, "__UNKNOWN__" }
            ,{  588, "__UNKNOWN__" }
            ,{  589, "__UNKNOWN__" }
            ,{  590, "__UNKNOWN__" }
            ,{  591, "__UNKNOWN__" }
            ,{  592, "__UNKNOWN__" }
            ,{  593, "__UNKNOWN__" }
            ,{  594, "Honey" }
            ,{  595, "Mixed Honey" }
            ,{  596, "Snakebee Larva" }
            ,{  597, "__UNKNOWN__" }
            ,{  598, "Hakolo Honey" }
            ,{  599, "Alcala Honey" }

            ,{  600, "Loloska Honey" }
            ,{  601, "__UNKNOWN__" }
            ,{  602, "__UNKNOWN__" }
            ,{  603, "__UNKNOWN__" }
            ,{  604, "__UNKNOWN__" }
            ,{  605, "__UNKNOWN__" }
            ,{  606, "__UNKNOWN__" }
            ,{  607, "Bitterbug" }
            ,{  608, "__UNKNOWN__" }
            ,{  609, "Flashbug" }
            ,{  610, "Shiny Beetle" }
            ,{  611, "Thunderbug" }
            ,{  612, "Insect Husk" }
            ,{  613, "__UNKNOWN__" }
            ,{  614, "__UNKNOWN__" }
            ,{  615, "__UNKNOWN__" }
            ,{  616, "__UNKNOWN__" }
            ,{  617, "Spider Web" }
            ,{  618, "Carpenterbug" }
            ,{  619, "__UNKNOWN__" }
            ,{  620, "__UNKNOWN__" }
            ,{  621, "__UNKNOWN__" }
            ,{  622, "__UNKNOWN__" }
            ,{  623, "__UNKNOWN__" }
            ,{  624, "__UNKNOWN__" }
            ,{  625, "__UNKNOWN__" }
            ,{  626, "__UNKNOWN__" }
            ,{  627, "__UNKNOWN__" }
            ,{  628, "__UNKNOWN__" }
            ,{  629, "__UNKNOWN__" }
            ,{  630, "__UNKNOWN__" }
            ,{  631, "__UNKNOWN__" }
            ,{  632, "__UNKNOWN__" }
            ,{  633, "Iron Ore" }
            ,{  634, "Earth Crystal" }
            ,{  635, "Pelagicite Ore" }
            ,{  636, "Malachite Ore" }
            ,{  637, "Dragonite Ore" }
            ,{  638, "__UNKNOWN__" }
            ,{  639, "__UNKNOWN__" }
            ,{  640, "__UNKNOWN__" }
            ,{  641, "__UNKNOWN__" }
            ,{  642, "__UNKNOWN__" }
            ,{  643, "__UNKNOWN__" }
            ,{  644, "Lightcrystal" }
            ,{  645, "__UNKNOWN__" }
            ,{  646, "__UNKNOWN__" }
            ,{  647, "__UNKNOWN__" }
            ,{  648, "__UNKNOWN__" }
            ,{  649, "__UNKNOWN__" }
            ,{  650, "__UNKNOWN__" }
            ,{  651, "__UNKNOWN__" }
            ,{  652, "__UNKNOWN__" }
            ,{  653, "__UNKNOWN__" }
            ,{  654, "__UNKNOWN__" }
            ,{  655, "__UNKNOWN__" }
            ,{  656, "__UNKNOWN__" }
            ,{  657, "__UNKNOWN__" }
            ,{  658, "__UNKNOWN__" }
            ,{  659, "__UNKNOWN__" }
            ,{  660, "__UNKNOWN__" }
            ,{  661, "__UNKNOWN__" }
            ,{  662, "__UNKNOWN__" }
            ,{  663, "__UNKNOWN__" }
            ,{  664, "__UNKNOWN__" }
            ,{  665, "__UNKNOWN__" }
            ,{  666, "__UNKNOWN__" }
            ,{  667, "__UNKNOWN__" }
            ,{  668, "__UNKNOWN__" }
            ,{  669, "__UNKNOWN__" }
            ,{  670, "__UNKNOWN__" }
            ,{  671, "__UNKNOWN__" }
            ,{  672, "__UNKNOWN__" }
            ,{  673, "__UNKNOWN__" }
            ,{  674, "__UNKNOWN__" }
            ,{  675, "__UNKNOWN__" }
            ,{  676, "__UNKNOWN__" }
            ,{  677, "__UNKNOWN__" }
            ,{  678, "__UNKNOWN__" }
            ,{  679, "__UNKNOWN__" }
            ,{  680, "__UNKNOWN__" }
            ,{  681, "__UNKNOWN__" }
            ,{  682, "__UNKNOWN__" }
            ,{  683, "__UNKNOWN__" }
            ,{  684, "__UNKNOWN__" }
            ,{  685, "__UNKNOWN__" }
            ,{  686, "__UNKNOWN__" }
            ,{  687, "__UNKNOWN__" }
            ,{  688, "__UNKNOWN__" }
            ,{  689, "__UNKNOWN__" }
            ,{  690, "Sleepyfish" }
            ,{  691, "__UNKNOWN__" }
            ,{  692, "__UNKNOWN__" }
            ,{  693, "__UNKNOWN__" }
            ,{  694, "__UNKNOWN__" }
            ,{  695, "__UNKNOWN__" }
            ,{  696, "__UNKNOWN__" }
            ,{  697, "__UNKNOWN__" }
            ,{  698, "__UNKNOWN__" }
            ,{  699, "__UNKNOWN__" }

            ,{  700, "__UNKNOWN__" }
            ,{  701, "__UNKNOWN__" }
            ,{  702, "__UNKNOWN__" }
            ,{  703, "__UNKNOWN__" }
            ,{  704, "__UNKNOWN__" }
            ,{  705, "__UNKNOWN__" }
            ,{  706, "__UNKNOWN__" }
            ,{  707, "__UNKNOWN__" }
            ,{  708, "__UNKNOWN__" }
            ,{  709, "Raw Meat" }
            ,{  710, "__UNKNOWN__" }
            ,{  711, "Quality Meat" }
            ,{  712, "__UNKNOWN__" }
            ,{  713, "__UNKNOWN__" }
            ,{  714, "__UNKNOWN__" }
            ,{  715, "__UNKNOWN__" }
            ,{  716, "__UNKNOWN__" }
            ,{  717, "__UNKNOWN__" }
            ,{  718, "__UNKNOWN__" }
            ,{  719, "__UNKNOWN__" }
            ,{  720, "__UNKNOWN__" }
            ,{  721, "Wyvern Barbs" }
            ,{  722, "__UNKNOWN__" }
            ,{  723, "Screamer Sac" }
            ,{  724, "__UNKNOWN__" }
            ,{  725, "Poison Sac" }
            ,{  726, "__UNKNOWN__" }
            ,{  727, "__UNKNOWN__" }
            ,{  728, "__UNKNOWN__" }
            ,{  729, "Sleep Sac" }
            ,{  730, "__UNKNOWN__" }
            ,{  731, "__UNKNOWN__" }
            ,{  732, "__UNKNOWN__" }
            ,{  733, "Flame Sac" }
            ,{  734, "__UNKNOWN__" }
            ,{  735, "Aqua Sac" }
            ,{  736, "__UNKNOWN__" }
            ,{  737, "__UNKNOWN__" }
            ,{  738, "__UNKNOWN__" }
            ,{  739, "Frost Sac" }
            ,{  740, "__UNKNOWN__" }
            ,{  741, "__UNKNOWN__" }
            ,{  742, "__UNKNOWN__" }
            ,{  743, "Wyvern Stone" }
            ,{  744, "__UNKNOWN__" }
            ,{  745, "Larinoth Hide" }
            ,{  746, "__UNKNOWN__" }
            ,{  747, "__UNKNOWN__" }
            ,{  748, "__UNKNOWN__" }
            ,{  749, "__UNKNOWN__" }
            ,{  750, "__UNKNOWN__" }
            ,{  751, "__UNKNOWN__" }
            ,{  752, "__UNKNOWN__" }
            ,{  753, "__UNKNOWN__" }
            ,{  754, "__UNKNOWN__" }
            ,{  755, "__UNKNOWN__" }
            ,{  756, "__UNKNOWN__" }
            ,{  757, "__UNKNOWN__" }
            ,{  758, "Rathian Shell" }
            ,{  759, "Rathian Spike" }
            ,{  760, "__UNKNOWN__" }
            ,{  761, "__UNKNOWN__" }
            ,{  762, "__UNKNOWN__" }
            ,{  763, "__UNKNOWN__" }
            ,{  764, "__UNKNOWN__" }
            ,{  765, "__UNKNOWN__" }
            ,{  766, "__UNKNOWN__" }
            ,{  767, "__UNKNOWN__" }
            ///////////////////////////////
            //                           //
            // 0x300 -> 0x3FF Facilities //
            //                           //
            ///////////////////////////////
            ,{  768, "__UNKNOWN__" }
            ,{  769, "__UNKNOWN__" }
            ,{  770, "__UNKNOWN__" }
            ,{  771, "__UNKNOWN__" }
            ,{  772, "__UNKNOWN__" }
            ,{  773, "__UNKNOWN__" }
            ,{  774, "__UNKNOWN__" }
            ,{  775, "__UNKNOWN__" }
            ,{  776, "__UNKNOWN__" }
            ,{  777, "__UNKNOWN__" }
            ,{  778, "__UNKNOWN__" }
            ,{  779, "__UNKNOWN__" }
            ,{  780, "__UNKNOWN__" }
            ,{  781, "__UNKNOWN__" }
            ,{  782, "__UNKNOWN__" }
            ,{  783, "__UNKNOWN__" }
            ,{  784, "__UNKNOWN__" }
            ,{  785, "__UNKNOWN__" }
            ,{  786, "__UNKNOWN__" }
            ,{  787, "__UNKNOWN__" }
            ,{  788, "Kut-Ku Scale" }
            ,{  789, "Kut-Ku Webbing" }
            ,{  790, "Giant Beak" }
            ,{  791, "__UNKNOWN__" }
            ,{  792, "__UNKNOWN__" }
            ,{  793, "__UNKNOWN__" }
            ,{  794, "Blue Kut-Ku Scale" }
            ,{  795, "Blue Kut-Ku Shell" }
            ,{  796, "Blue Kut-Ku Ear" }
            ,{  797, "__UNKNOWN__" }
            ,{  798, "__UNKNOWN__" }
            ,{  799, "__UNKNOWN__" }
            ,{  800, "__UNKNOWN__" }
            ,{  801, "__UNKNOWN__" }
            ,{  802, "__UNKNOWN__" }
            ,{  803, "__UNKNOWN__" }
            ,{  804, "__UNKNOWN__" }
            ,{  805, "__UNKNOWN__" }
            ,{  806, "__UNKNOWN__" }
            ,{  807, "__UNKNOWN__" }
            ,{  808, "__UNKNOWN__" }
            ,{  809, "__UNKNOWN__" }
            ,{  810, "__UNKNOWN__" }
            ,{  811, "__UNKNOWN__" }
            ,{  812, "Tigrex Scale" }
            ,{  813, "__UNKNOWN__" }
            ,{  814, "__UNKNOWN__" }
            ,{  815, "__UNKNOWN__" }
            ,{  816, "__UNKNOWN__" }
            ,{  817, "__UNKNOWN__" }
            ,{  818, "__UNKNOWN__" }
            ,{  819, "__UNKNOWN__" }
            ,{  820, "__UNKNOWN__" }
            ,{  821, "__UNKNOWN__" }
            ,{  822, "__UNKNOWN__" }
            ,{  823, "__UNKNOWN__" }
            ,{  824, "__UNKNOWN__" }
            ,{  825, "__UNKNOWN__" }
            ,{  826, "__UNKNOWN__" }
            ,{  827, "__UNKNOWN__" }
            ,{  828, "__UNKNOWN__" }
            ,{  829, "__UNKNOWN__" }
            ,{  830, "__UNKNOWN__" }
            ,{  831, "__UNKNOWN__" }
            ,{  832, "__UNKNOWN__" }
            ,{  833, "__UNKNOWN__" }
            ,{  834, "__UNKNOWN__" }
            ,{  835, "__UNKNOWN__" }
            ,{  836, "__UNKNOWN__" }
            ,{  837, "__UNKNOWN__" }
            ,{  838, "__UNKNOWN__" }
            ,{  839, "Great Jaggi Hide" }
            ,{  840, "Great Jaggi Claw" }
            ,{  841, "King's Frill" }
            ,{  842, "__UNKNOWN__" }
            ,{  843, "__UNKNOWN__" }
            ,{  844, "__UNKNOWN__" }
            ,{  845, "Velocidrome Hide" }
            ,{  846, "Velocidrome Claw" }
            ,{  847, "Velocidrome Head" }
            ,{  848, "__UNKNOWN__" }
            ,{  849, "__UNKNOWN__" }
            ,{  850, "__UNKNOWN__" }
            ,{  851, "__UNKNOWN__" }
            ,{  852, "__UNKNOWN__" }
            ,{  853, "__UNKNOWN__" }
            ,{  854, "__UNKNOWN__" }
            ,{  855, "__UNKNOWN__" }
            ,{  856, "__UNKNOWN__" }
            ,{  857, "__UNKNOWN__" }
            ,{  858, "__UNKNOWN__" }
            ,{  859, "__UNKNOWN__" }
            ,{  860, "__UNKNOWN__" }
            ,{  861, "__UNKNOWN__" }
            ,{  862, "__UNKNOWN__" }
            ,{  863, "__UNKNOWN__" }
            ,{  864, "__UNKNOWN__" }
            ,{  865, "__UNKNOWN__" }
            ,{  866, "__UNKNOWN__" }
            ,{  867, "__UNKNOWN__" }
            ,{  868, "__UNKNOWN__" }
            ,{  869, "__UNKNOWN__" }
            ,{  870, "__UNKNOWN__" }
            ,{  871, "__UNKNOWN__" }
            ,{  872, "__UNKNOWN__" }
            ,{  873, "__UNKNOWN__" }
            ,{  874, "__UNKNOWN__" }
            ,{  875, "Zamtrios Hide" }
            ,{  876, "Zamtrios Fin" }
            ,{  877, "Zamtrios Tailblade" }
            ,{  878, "__UNKNOWN__" }
            ,{  879, "__UNKNOWN__" }
            ,{  880, "__UNKNOWN__" }
            ,{  881, "__UNKNOWN__" }
            ,{  882, "__UNKNOWN__" }
            ,{  883, "__UNKNOWN__" }
            ,{  884, "__UNKNOWN__" }
            ,{  885, "__UNKNOWN__" }
            ,{  886, "__UNKNOWN__" }
            ,{  887, "Garuga Scale" }
            ,{  888, "Garuga Ear" }
            ,{  889, "Sharpened Beak" }
            ,{  890, "__UNKNOWN__" }
            ,{  891, "__UNKNOWN__" }
            ,{  892, "__UNKNOWN__" }
            ,{  893, "__UNKNOWN__" }
            ,{  894, "__UNKNOWN__" }
            ,{  895, "__UNKNOWN__" }
            ,{  896, "__UNKNOWN__" }
            ,{  897, "__UNKNOWN__" }
            ,{  898, "__UNKNOWN__" }
            ,{  899, "__UNKNOWN__" }
            ,{  900, "__UNKNOWN__" }
            ,{  901, "__UNKNOWN__" }
            ,{  902, "__UNKNOWN__" }
            ,{  903, "__UNKNOWN__" }
            ,{  904, "__UNKNOWN__" }
            ,{  905, "__UNKNOWN__" }
            ,{  906, "__UNKNOWN__" }
            ,{  907, "__UNKNOWN__" }
            ,{  908, "__UNKNOWN__" }
            ,{  909, "__UNKNOWN__" }
            ,{  910, "__UNKNOWN__" }
            ,{  911, "__UNKNOWN__" }
            ,{  912, "__UNKNOWN__" }
            ,{  913, "__UNKNOWN__" }
            ,{  914, "__UNKNOWN__" }
            ,{  915, "__UNKNOWN__" }
            ,{  916, "__UNKNOWN__" }
            ,{  917, "__UNKNOWN__" }
            ,{  918, "__UNKNOWN__" }
            ,{  919, "__UNKNOWN__" }
            ,{  920, "__UNKNOWN__" }
            ,{  921, "__UNKNOWN__" }
            ,{  922, "__UNKNOWN__" }
            ,{  923, "Basarios Shell" }
            ,{  924, "Basarios Webbing" }
            ,{  925, "Basarios Tears" }
            ,{  926, "__UNKNOWN__" }
            ,{  927, "__UNKNOWN__" }
            ,{  928, "__UNKNOWN__" }
            ,{  929, "__UNKNOWN__" }
            ,{  930, "__UNKNOWN__" }
            ,{  931, "__UNKNOWN__" }
            ,{  932, "__UNKNOWN__" }
            ,{  933, "__UNKNOWN__" }
            ,{  934, "__UNKNOWN__" }
            ,{  935, "__UNKNOWN__" }
            ,{  936, "__UNKNOWN__" }
            ,{  937, "__UNKNOWN__" }
            ,{  938, "__UNKNOWN__" }
            ,{  939, "__UNKNOWN__" }
            ,{  940, "__UNKNOWN__" }
            ,{  941, "__UNKNOWN__" }
            ,{  942, "__UNKNOWN__" }
            ,{  943, "__UNKNOWN__" }
            ,{  944, "__UNKNOWN__" }
            ,{  945, "__UNKNOWN__" }
            ,{  946, "__UNKNOWN__" }
            ,{  947, "__UNKNOWN__" }
            ,{  948, "__UNKNOWN__" }
            ,{  949, "__UNKNOWN__" }
            ,{  950, "__UNKNOWN__" }
            ,{  951, "__UNKNOWN__" }
            ,{  952, "__UNKNOWN__" }
            ,{  953, "__UNKNOWN__" }
            ,{  954, "__UNKNOWN__" }
            ,{  955, "__UNKNOWN__" }
            ,{  956, "__UNKNOWN__" }
            ,{  957, "__UNKNOWN__" }
            ,{  958, "__UNKNOWN__" }
            ,{  959, "__UNKNOWN__" }
            ,{  960, "__UNKNOWN__" }
            ,{  961, "__UNKNOWN__" }
            ,{  962, "__UNKNOWN__" }
            ,{  963, "__UNKNOWN__" }
            ,{  964, "__UNKNOWN__" }
            ,{  965, "__UNKNOWN__" }
            ,{  966, "__UNKNOWN__" }
            ,{  967, "__UNKNOWN__" }
            ,{  968, "__UNKNOWN__" }
            ,{  969, "__UNKNOWN__" }
            ,{  970, "__UNKNOWN__" }
            ,{  971, "__UNKNOWN__" }
            ,{  972, "__UNKNOWN__" }
            ,{  973, "__UNKNOWN__" }
            ,{  974, "__UNKNOWN__" }
            ,{  975, "__UNKNOWN__" }
            ,{  976, "__UNKNOWN__" }
            ,{  977, "__UNKNOWN__" }
            ,{  978, "__UNKNOWN__" }
            ,{  979, "__UNKNOWN__" }
            ,{  980, "__UNKNOWN__" }
            ,{  981, "__UNKNOWN__" }
            ,{  982, "__UNKNOWN__" }
            ,{  983, "__UNKNOWN__" }
            ,{  984, "__UNKNOWN__" }
            ,{  985, "__UNKNOWN__" }
            ,{  986, "__UNKNOWN__" }
            ,{  987, "__UNKNOWN__" }
            ,{  988, "__UNKNOWN__" }
            ,{  989, "__UNKNOWN__" }
            ,{  990, "__UNKNOWN__" }
            ,{  991, "__UNKNOWN__" }
            ,{  992, "__UNKNOWN__" }
            ,{  993, "__UNKNOWN__" }
            ,{  994, "__UNKNOWN__" }
            ,{  995, "__UNKNOWN__" }
            ,{  996, "__UNKNOWN__" }
            ,{  997, "__UNKNOWN__" }
            ,{  998, "__UNKNOWN__" }
            ,{  999, "__UNKNOWN__" }
            ,{ 1000, "__UNKNOWN__" }
            ,{ 1001, "__UNKNOWN__" }
            ,{ 1002, "__UNKNOWN__" }
            ,{ 1003, "__UNKNOWN__" }
            ,{ 1004, "__UNKNOWN__" }
            ,{ 1005, "__UNKNOWN__" }
            ,{ 1006, "__UNKNOWN__" }
            ,{ 1007, "__UNKNOWN__" }
            ,{ 1008, "__UNKNOWN__" }
            ,{ 1009, "__UNKNOWN__" }
            ,{ 1010, "__UNKNOWN__" }
            ,{ 1011, "__UNKNOWN__" }
            ,{ 1012, "__UNKNOWN__" }
            ,{ 1013, "__UNKNOWN__" }
            ,{ 1014, "__UNKNOWN__" }
            ,{ 1015, "__UNKNOWN__" }
            ,{ 1016, "__UNKNOWN__" }
            ,{ 1017, "__UNKNOWN__" }
            ,{ 1018, "__UNKNOWN__" }
            ,{ 1019, "__UNKNOWN__" }
            ,{ 1020, "__UNKNOWN__" }
            ,{ 1021, "__UNKNOWN__" }
            ,{ 1022, "__UNKNOWN__" }
            ,{ 1023, "__UNKNOWN__" }
            ///////////////////////////////
            //                           //
            // 0x400 -> 0x4FF Growth     //
            //                           //
            ///////////////////////////////
            ,{ 1024, "__UNKNOWN__" }
            ,{ 1025, "__UNKNOWN__" }
            ,{ 1026, "__UNKNOWN__" }
            ,{ 1027, "__UNKNOWN__" }
            ,{ 1028, "__UNKNOWN__" }
            ,{ 1029, "__UNKNOWN__" }
            ,{ 1030, "__UNKNOWN__" }
            ,{ 1031, "__UNKNOWN__" }
            ,{ 1032, "__UNKNOWN__" }
            ,{ 1033, "__UNKNOWN__" }
            ,{ 1034, "__UNKNOWN__" }
            ,{ 1035, "__UNKNOWN__" }
            ,{ 1036, "__UNKNOWN__" }
            ,{ 1037, "Great Baggi Hide" }
            ,{ 1038, "Great Baggi Claw" }
            ,{ 1039, "__UNKNOWN__" }
            ,{ 1040, "__UNKNOWN__" }
            ,{ 1041, "__UNKNOWN__" }
            ,{ 1042, "__UNKNOWN__" }
            ,{ 1043, "Royal Ludroth Scale" }
            ,{ 1044, "Royal Ludroth Tail" }
            ,{ 1045, "Royal Ludroth Crest" }
            ,{ 1046, "__UNKNOWN__" }
            ,{ 1047, "__UNKNOWN__" }
            ,{ 1048, "__UNKNOWN__" }
            ,{ 1049, "__UNKNOWN__" }
            ,{ 1050, "__UNKNOWN__" }
            ,{ 1051, "__UNKNOWN__" }
            ,{ 1052, "__UNKNOWN__" }
            ,{ 1053, "__UNKNOWN__" }
            ,{ 1054, "__UNKNOWN__" }
            ,{ 1055, "__UNKNOWN__" }
            ,{ 1056, "__UNKNOWN__" }
            ,{ 1057, "__UNKNOWN__" }
            ,{ 1058, "__UNKNOWN__" }
            ,{ 1059, "__UNKNOWN__" }
            ,{ 1060, "__UNKNOWN__" }
            ,{ 1061, "__UNKNOWN__" }
            ,{ 1062, "__UNKNOWN__" }
            ,{ 1063, "__UNKNOWN__" }
            ,{ 1064, "__UNKNOWN__" }
            ,{ 1065, "__UNKNOWN__" }
            ,{ 1066, "__UNKNOWN__" }
            ,{ 1067, "__UNKNOWN__" }
            ,{ 1068, "__UNKNOWN__" }
            ,{ 1069, "__UNKNOWN__" }
            ,{ 1070, "__UNKNOWN__" }
            ,{ 1071, "__UNKNOWN__" }
            ,{ 1072, "__UNKNOWN__" }
            ,{ 1073, "__UNKNOWN__" }
            ,{ 1074, "__UNKNOWN__" }
            ,{ 1075, "__UNKNOWN__" }
            ,{ 1076, "__UNKNOWN__" }
            ,{ 1077, "__UNKNOWN__" }
            ,{ 1078, "__UNKNOWN__" }
            ,{ 1079, "Qurupeco Tail" }
            ,{ 1080, "Qurupeco Feather" }
            ,{ 1081, "Strange Beak" }
            ,{ 1082, "__UNKNOWN__" }
            ,{ 1083, "__UNKNOWN__" }
            ,{ 1084, "__UNKNOWN__" }
            ,{ 1085, "__UNKNOWN__" }
            ,{ 1086, "__UNKNOWN__" }
            ,{ 1087, "__UNKNOWN__" }
            ,{ 1088, "__UNKNOWN__" }
            ,{ 1089, "__UNKNOWN__" }
            ,{ 1090, "__UNKNOWN__" }
            ,{ 1091, "Bulldrome Hide" }
            ,{ 1092, "Bulldrome Tusk" }
            ,{ 1093, "Bulldrome Bone" }
            ,{ 1094, "__UNKNOWN__" }
            ,{ 1095, "__UNKNOWN__" }
            ,{ 1096, "__UNKNOWN__" }
            ,{ 1097, "Arzuros Pelt" }
            ,{ 1098, "Arzuros Shell" }
            ,{ 1099, "Arzuros Brace" }
            ,{ 1100, "__UNKNOWN__" }
            ,{ 1101, "__UNKNOWN__" }
            ,{ 1102, "__UNKNOWN__" }
            ,{ 1103, "__UNKNOWN__" }
            ,{ 1104, "__UNKNOWN__" }
            ,{ 1105, "__UNKNOWN__" }
            ,{ 1106, "__UNKNOWN__" }
            ,{ 1107, "__UNKNOWN__" }
            ,{ 1108, "__UNKNOWN__" }
            ,{ 1109, "__UNKNOWN__" }
            ,{ 1110, "__UNKNOWN__" }
            ,{ 1111, "__UNKNOWN__" }
            ,{ 1112, "__UNKNOWN__" }
            ,{ 1113, "__UNKNOWN__" }
            ,{ 1114, "__UNKNOWN__" }
            ,{ 1115, "__UNKNOWN__" }
            ,{ 1116, "__UNKNOWN__" }
            ,{ 1117, "__UNKNOWN__" }
            ,{ 1118, "__UNKNOWN__" }
            ,{ 1119, "__UNKNOWN__" }
            ,{ 1120, "__UNKNOWN__" }
            ,{ 1121, "__UNKNOWN__" }
            ,{ 1122, "__UNKNOWN__" }
            ,{ 1123, "__UNKNOWN__" }
            ,{ 1124, "__UNKNOWN__" }
            ,{ 1125, "__UNKNOWN__" }
            ,{ 1126, "__UNKNOWN__" }
            ,{ 1127, "__UNKNOWN__" }
            ,{ 1128, "__UNKNOWN__" }
            ,{ 1129, "__UNKNOWN__" }
            ,{ 1130, "__UNKNOWN__" }
            ,{ 1131, "__UNKNOWN__" }
            ,{ 1132, "__UNKNOWN__" }
            ,{ 1133, "__UNKNOWN__" }
            ,{ 1134, "__UNKNOWN__" }
            ,{ 1135, "__UNKNOWN__" }
            ,{ 1136, "__UNKNOWN__" }
            ,{ 1137, "__UNKNOWN__" }
            ,{ 1138, "__UNKNOWN__" }
            ,{ 1139, "__UNKNOWN__" }
            ,{ 1140, "__UNKNOWN__" }
            ,{ 1141, "__UNKNOWN__" }
            ,{ 1142, "__UNKNOWN__" }
            ,{ 1143, "__UNKNOWN__" }
            ,{ 1144, "__UNKNOWN__" }
            ,{ 1145, "__UNKNOWN__" }
            ,{ 1146, "__UNKNOWN__" }
            ,{ 1147, "__UNKNOWN__" }
            ,{ 1148, "__UNKNOWN__" }
            ,{ 1149, "__UNKNOWN__" }
            ,{ 1150, "__UNKNOWN__" }
            ,{ 1151, "Nargacuga Scale" }
            ,{ 1152, "Nargacuga Blackfur" }
            ,{ 1153, "__UNKNOWN__" }
            ,{ 1154, "__UNKNOWN__" }
            ,{ 1155, "__UNKNOWN__" }
            ,{ 1156, "__UNKNOWN__" }
            ,{ 1157, "__UNKNOWN__" }
            ,{ 1158, "__UNKNOWN__" }
            ,{ 1159, "__UNKNOWN__" }
            ,{ 1160, "__UNKNOWN__" }
            ,{ 1161, "__UNKNOWN__" }
            ,{ 1162, "__UNKNOWN__" }
            ,{ 1163, "__UNKNOWN__" }
            ,{ 1164, "Monster Bone S" }
            ,{ 1165, "Monster Bone M" }
            ,{ 1166, "Brute Bone S" }
            ,{ 1167, "Monster Fluid" }
            ,{ 1168, "__UNKNOWN__" }
            ,{ 1169, "Slagtoth Hide" }
            ,{ 1170, "Aptonoth Tail" }
            ,{ 1171, "__UNKNOWN__" }
            ,{ 1172, "Ludroth Pelt" }
            ,{ 1173, "__UNKNOWN__" }
            ,{ 1174, "Bullfango Pelt" }
            ,{ 1175, "__UNKNOWN__" }
            ,{ 1176, "__UNKNOWN__" }
            ,{ 1177, "Bnahabra Shell" }
            ,{ 1178, "__UNKNOWN__" }
            ,{ 1179, "Konchu Shell" }
            ,{ 1180, "__UNKNOWN__" }
            ,{ 1181, "__UNKNOWN__" }
            ,{ 1182, "Jaggi Scale" }
            ,{ 1183, "__UNKNOWN__" }
            ,{ 1184, "Velociprey Scale" }
            ,{ 1185, "__UNKNOWN__" }
            ,{ 1186, "__UNKNOWN__" }
            ,{ 1187, "__UNKNOWN__" }
            ,{ 1188, "__UNKNOWN__" }
            ,{ 1189, "__UNKNOWN__" }
            ,{ 1190, "__UNKNOWN__" }
            ,{ 1191, "Gargwa Feather" }
            ,{ 1192, "Monster Bone L" }
            ,{ 1193, "__UNKNOWN__" }
            ,{ 1194, "__UNKNOWN__" }
            ,{ 1195, "__UNKNOWN__" }
            ,{ 1196, "Kelbi Horn" }
            ,{ 1197, "Apceros Shell" }
            ,{ 1198, "__UNKNOWN__" }
            ,{ 1199, "__UNKNOWN__" }
            ,{ 1200, "__UNKNOWN__" }
            ,{ 1201, "__UNKNOWN__" }
            ,{ 1202, "__UNKNOWN__" }
            ,{ 1203, "__UNKNOWN__" }
            ,{ 1204, "__UNKNOWN__" }
            ,{ 1205, "__UNKNOWN__" }
            ,{ 1206, "__UNKNOWN__" }
            ,{ 1207, "__UNKNOWN__" }
            ,{ 1208, "__UNKNOWN__" }
            ,{ 1209, "__UNKNOWN__" }
            ,{ 1210, "__UNKNOWN__" }
            ,{ 1211, "__UNKNOWN__" }
            ,{ 1212, "__UNKNOWN__" }
            ,{ 1213, "__UNKNOWN__" }
            ,{ 1214, "__UNKNOWN__" }
            ,{ 1215, "__UNKNOWN__" }
            ,{ 1216, "__UNKNOWN__" }
            ,{ 1217, "__UNKNOWN__" }
            ,{ 1218, "Brute Bone M" }
            ,{ 1219, "Brute Bone L" }
            ,{ 1220, "__UNKNOWN__" }
            ,{ 1221, "__UNKNOWN__" }
            ,{ 1222, "__UNKNOWN__" }
            ,{ 1223, "__UNKNOWN__" }
            ,{ 1224, "__UNKNOWN__" }
            ,{ 1225, "__UNKNOWN__" }
            ,{ 1226, "__UNKNOWN__" }
            ,{ 1227, "__UNKNOWN__" }
            ,{ 1228, "__UNKNOWN__" }
            ,{ 1229, "__UNKNOWN__" }
            ,{ 1230, "__UNKNOWN__" }
            ,{ 1231, "__UNKNOWN__" }
            ,{ 1232, "__UNKNOWN__" }
            ,{ 1233, "__UNKNOWN__" }
            ,{ 1234, "__UNKNOWN__" }
            ,{ 1235, "__UNKNOWN__" }
            ,{ 1236, "__UNKNOWN__" }
            ,{ 1237, "__UNKNOWN__" }
            ,{ 1238, "__UNKNOWN__" }
            ,{ 1239, "__UNKNOWN__" }
            ,{ 1240, "__UNKNOWN__" }
            ,{ 1241, "__UNKNOWN__" }
            ,{ 1242, "__UNKNOWN__" }
            ,{ 1243, "__UNKNOWN__" }
            ,{ 1244, "__UNKNOWN__" }
            ,{ 1245, "__UNKNOWN__" }
            ,{ 1246, "__UNKNOWN__" }
            ,{ 1247, "__UNKNOWN__" }
            ,{ 1248, "__UNKNOWN__" }
            ,{ 1249, "__UNKNOWN__" }
            ,{ 1250, "__UNKNOWN__" }
            ,{ 1251, "__UNKNOWN__" }
            ,{ 1252, "__UNKNOWN__" }
            ,{ 1253, "__UNKNOWN__" }
            ,{ 1254, "__UNKNOWN__" }
            ,{ 1255, "__UNKNOWN__" }
            ,{ 1256, "__UNKNOWN__" }
            ,{ 1257, "__UNKNOWN__" }
            ,{ 1258, "__UNKNOWN__" }
            ,{ 1259, "__UNKNOWN__" }
            ,{ 1260, "__UNKNOWN__" }
            ,{ 1261, "__UNKNOWN__" }
            ,{ 1262, "__UNKNOWN__" }
            ,{ 1263, "__UNKNOWN__" }
            ,{ 1264, "__UNKNOWN__" }
            ,{ 1265, "__UNKNOWN__" }
            ,{ 1266, "__UNKNOWN__" }
            ,{ 1267, "__UNKNOWN__" }
            ,{ 1268, "__UNKNOWN__" }
            ,{ 1269, "__UNKNOWN__" }
            ,{ 1270, "__UNKNOWN__" }
            ,{ 1271, "__UNKNOWN__" }
            ,{ 1272, "__UNKNOWN__" }
            ,{ 1273, "__UNKNOWN__" }
            ,{ 1274, "__UNKNOWN__" }
            ,{ 1275, "__UNKNOWN__" }
            ,{ 1276, "__UNKNOWN__" }
            ,{ 1277, "__UNKNOWN__" }
            ,{ 1278, "__UNKNOWN__" }
            ,{ 1279, "__UNKNOWN__" }
            ///////////////////////////////
            //                           //
            // 0x500 -> 0x5FF Key Items  //
            //                           //
            ///////////////////////////////
            ,{ 1280, "__UNKNOWN__" }
            ,{ 1281, "__UNKNOWN__" }
            ,{ 1282, "__UNKNOWN__" }
            ,{ 1283, "__UNKNOWN__" }
            ,{ 1284, "__UNKNOWN__" }
            ,{ 1285, "__UNKNOWN__" }
            ,{ 1286, "__UNKNOWN__" }
            ,{ 1287, "__UNKNOWN__" }
            ,{ 1288, "__UNKNOWN__" }
            ,{ 1289, "__UNKNOWN__" }
            ,{ 1290, "__UNKNOWN__" }
            ,{ 1291, "__UNKNOWN__" }
            ,{ 1292, "__UNKNOWN__" }
            ,{ 1293, "__UNKNOWN__" }
            ,{ 1294, "__UNKNOWN__" }
            ,{ 1295, "__UNKNOWN__" }
            ,{ 1296, "__UNKNOWN__" }
            ,{ 1297, "__UNKNOWN__" }
            ,{ 1298, "__UNKNOWN__" }
            ,{ 1299, "__UNKNOWN__" }
            ,{ 1300, "__UNKNOWN__" }
            ,{ 1301, "__UNKNOWN__" }
            ,{ 1302, "__UNKNOWN__" }
            ,{ 1303, "__UNKNOWN__" }
            ,{ 1304, "__UNKNOWN__" }
            ,{ 1305, "__UNKNOWN__" }
            ,{ 1306, "__UNKNOWN__" }
            ,{ 1307, "__UNKNOWN__" }
            ,{ 1308, "__UNKNOWN__" }
            ,{ 1309, "__UNKNOWN__" }
            ,{ 1310, "__UNKNOWN__" }
            ,{ 1311, "__UNKNOWN__" }
            ,{ 1312, "__UNKNOWN__" }
            ,{ 1313, "__UNKNOWN__" }
            ,{ 1314, "__UNKNOWN__" }
            ,{ 1315, "__UNKNOWN__" }
            ,{ 1316, "__UNKNOWN__" }
            ,{ 1317, "__UNKNOWN__" }
            ,{ 1318, "__UNKNOWN__" }
            ,{ 1319, "__UNKNOWN__" }
            ,{ 1320, "__UNKNOWN__" }
            ,{ 1321, "__UNKNOWN__" }
            ,{ 1322, "__UNKNOWN__" }
            ,{ 1323, "__UNKNOWN__" }
            ,{ 1324, "__UNKNOWN__" }
            ,{ 1325, "__UNKNOWN__" }
            ,{ 1326, "__UNKNOWN__" }
            ,{ 1327, "__UNKNOWN__" }
            ,{ 1328, "__UNKNOWN__" }
            ,{ 1329, "__UNKNOWN__" }
            ,{ 1330, "__UNKNOWN__" }
            ,{ 1331, "__UNKNOWN__" }
            ,{ 1332, "__UNKNOWN__" }
            ,{ 1333, "__UNKNOWN__" }
            ,{ 1334, "__UNKNOWN__" }
            ,{ 1335, "__UNKNOWN__" }
            ,{ 1336, "__UNKNOWN__" }
            ,{ 1337, "__UNKNOWN__" }
            ,{ 1338, "__UNKNOWN__" }
            ,{ 1339, "__UNKNOWN__" }
            ,{ 1340, "__UNKNOWN__" }
            ,{ 1341, "__UNKNOWN__" }
            ,{ 1342, "__UNKNOWN__" }
            ,{ 1343, "__UNKNOWN__" }
            ,{ 1344, "__UNKNOWN__" }
            ,{ 1345, "__UNKNOWN__" }
            ,{ 1346, "__UNKNOWN__" }
            ,{ 1347, "__UNKNOWN__" }
            ,{ 1348, "__UNKNOWN__" }
            ,{ 1349, "__UNKNOWN__" }
            ,{ 1350, "__UNKNOWN__" }
            ,{ 1351, "__UNKNOWN__" }
            ,{ 1352, "__UNKNOWN__" }
            ,{ 1353, "__UNKNOWN__" }
            ,{ 1354, "__UNKNOWN__" }
            ,{ 1355, "__UNKNOWN__" }
            ,{ 1356, "__UNKNOWN__" }
            ,{ 1357, "__UNKNOWN__" }
            ,{ 1358, "__UNKNOWN__" }
            ,{ 1359, "__UNKNOWN__" }
            ,{ 1360, "__UNKNOWN__" }
            ,{ 1361, "__UNKNOWN__" }
            ,{ 1362, "__UNKNOWN__" }
            ,{ 1363, "__UNKNOWN__" }
            ,{ 1364, "__UNKNOWN__" }
            ,{ 1365, "__UNKNOWN__" }
            ,{ 1366, "__UNKNOWN__" }
            ,{ 1367, "__UNKNOWN__" }
            ,{ 1368, "__UNKNOWN__" }
            ,{ 1369, "__UNKNOWN__" }
            ,{ 1370, "__UNKNOWN__" }
            ,{ 1371, "__UNKNOWN__" }
            ,{ 1372, "__UNKNOWN__" }
            ,{ 1373, "__UNKNOWN__" }
            ,{ 1374, "__UNKNOWN__" }
            ,{ 1375, "__UNKNOWN__" }
            ,{ 1376, "__UNKNOWN__" }
            ,{ 1377, "__UNKNOWN__" }
            ,{ 1378, "__UNKNOWN__" }
            ,{ 1379, "__UNKNOWN__" }
            ,{ 1380, "__UNKNOWN__" }
            ,{ 1381, "__UNKNOWN__" }
            ,{ 1382, "__UNKNOWN__" }
            ,{ 1383, "__UNKNOWN__" }
            ,{ 1384, "__UNKNOWN__" }
            ,{ 1385, "__UNKNOWN__" }
            ,{ 1386, "__UNKNOWN__" }
            ,{ 1387, "__UNKNOWN__" }
            ,{ 1388, "__UNKNOWN__" }
            ,{ 1389, "__UNKNOWN__" }
            ,{ 1390, "__UNKNOWN__" }
            ,{ 1391, "__UNKNOWN__" }
            ,{ 1392, "__UNKNOWN__" }
            ,{ 1393, "__UNKNOWN__" }
            ,{ 1394, "__UNKNOWN__" }
            ,{ 1395, "__UNKNOWN__" }
            ,{ 1396, "__UNKNOWN__" }
            ,{ 1397, "__UNKNOWN__" }
            ,{ 1398, "__UNKNOWN__" }
            ,{ 1399, "__UNKNOWN__" }
            ,{ 1400, "__UNKNOWN__" }
            ,{ 1401, "__UNKNOWN__" }
            ,{ 1402, "__UNKNOWN__" }
            ,{ 1403, "__UNKNOWN__" }
            ,{ 1404, "__UNKNOWN__" }
            ,{ 1405, "__UNKNOWN__" }
            ,{ 1406, "__UNKNOWN__" }
            ,{ 1407, "__UNKNOWN__" }
            ,{ 1408, "__UNKNOWN__" }
            ,{ 1409, "__UNKNOWN__" }
            ,{ 1410, "__UNKNOWN__" }
            ,{ 1411, "__UNKNOWN__" }
            ,{ 1412, "__UNKNOWN__" }
            ,{ 1413, "__UNKNOWN__" }
            ,{ 1414, "__UNKNOWN__" }
            ,{ 1415, "__UNKNOWN__" }
            ,{ 1416, "__UNKNOWN__" }
            ,{ 1417, "__UNKNOWN__" }
            ,{ 1418, "__UNKNOWN__" }
            ,{ 1419, "__UNKNOWN__" }
            ,{ 1420, "__UNKNOWN__" }
            ,{ 1421, "__UNKNOWN__" }
            ,{ 1422, "__UNKNOWN__" }
            ,{ 1423, "__UNKNOWN__" }
            ,{ 1424, "__UNKNOWN__" }
            ,{ 1425, "__UNKNOWN__" }
            ,{ 1426, "__UNKNOWN__" }
            ,{ 1427, "__UNKNOWN__" }
            ,{ 1428, "__UNKNOWN__" }
            ,{ 1429, "__UNKNOWN__" }
            ,{ 1430, "__UNKNOWN__" }
            ,{ 1431, "__UNKNOWN__" }
            ,{ 1432, "__UNKNOWN__" }
            ,{ 1433, "__UNKNOWN__" }
            ,{ 1434, "__UNKNOWN__" }
            ,{ 1435, "__UNKNOWN__" }
            ,{ 1436, "__UNKNOWN__" }
            ,{ 1437, "__UNKNOWN__" }
            ,{ 1438, "__UNKNOWN__" }
            ,{ 1439, "__UNKNOWN__" }
            ,{ 1440, "__UNKNOWN__" }
            ,{ 1441, "__UNKNOWN__" }
            ,{ 1442, "__UNKNOWN__" }
            ,{ 1443, "__UNKNOWN__" }
            ,{ 1444, "__UNKNOWN__" }
            ,{ 1445, "__UNKNOWN__" }
            ,{ 1446, "__UNKNOWN__" }
            ,{ 1447, "__UNKNOWN__" }
            ,{ 1448, "__UNKNOWN__" }
            ,{ 1449, "__UNKNOWN__" }
            ,{ 1450, "__UNKNOWN__" }
            ,{ 1451, "__UNKNOWN__" }
            ,{ 1452, "__UNKNOWN__" }
            ,{ 1453, "__UNKNOWN__" }
            ,{ 1454, "__UNKNOWN__" }
            ,{ 1455, "__UNKNOWN__" }
            ,{ 1456, "__UNKNOWN__" }
            ,{ 1457, "__UNKNOWN__" }
            ,{ 1458, "__UNKNOWN__" }
            ,{ 1459, "__UNKNOWN__" }
            ,{ 1460, "__UNKNOWN__" }
            ,{ 1461, "__UNKNOWN__" }
            ,{ 1462, "__UNKNOWN__" }
            ,{ 1463, "__UNKNOWN__" }
            ,{ 1464, "__UNKNOWN__" }
            ,{ 1465, "__UNKNOWN__" }
            ,{ 1466, "__UNKNOWN__" }
            ,{ 1467, "__UNKNOWN__" }
            ,{ 1468, "__UNKNOWN__" }
            ,{ 1469, "__UNKNOWN__" }
            ,{ 1470, "__UNKNOWN__" }
            ,{ 1471, "__UNKNOWN__" }
            ,{ 1472, "__UNKNOWN__" }
            ,{ 1473, "__UNKNOWN__" }
            ,{ 1474, "__UNKNOWN__" }
            ,{ 1475, "__UNKNOWN__" }
            ,{ 1476, "__UNKNOWN__" }
            ,{ 1477, "__UNKNOWN__" }
            ,{ 1478, "__UNKNOWN__" }
            ,{ 1479, "__UNKNOWN__" }
            ,{ 1480, "__UNKNOWN__" }
            ,{ 1481, "__UNKNOWN__" }
            ,{ 1482, "__UNKNOWN__" }
            ,{ 1483, "__UNKNOWN__" }
            ,{ 1484, "__UNKNOWN__" }
            ,{ 1485, "__UNKNOWN__" }
            ,{ 1486, "Heart Churro" }
            ,{ 1487, "__UNKNOWN__" }
            ,{ 1488, "__UNKNOWN__" }
            ,{ 1489, "__UNKNOWN__" }
            ,{ 1490, "__UNKNOWN__" }
            ,{ 1491, "__UNKNOWN__" }
            ,{ 1492, "__UNKNOWN__" }
            ,{ 1493, "__UNKNOWN__" }
            ,{ 1494, "__UNKNOWN__" }
            ,{ 1495, "__UNKNOWN__" }
            ,{ 1496, "__UNKNOWN__" }
            ,{ 1497, "__UNKNOWN__" }
            ,{ 1498, "__UNKNOWN__" }
            ,{ 1499, "__UNKNOWN__" }
            ,{ 1500, "__UNKNOWN__" }
            ,{ 1501, "__UNKNOWN__" }
            ,{ 1502, "__UNKNOWN__" }
            ,{ 1503, "__UNKNOWN__" }
            ,{ 1504, "__UNKNOWN__" }
            ,{ 1505, "__UNKNOWN__" }
            ,{ 1506, "__UNKNOWN__" }
            ,{ 1507, "__UNKNOWN__" }
            ,{ 1508, "__UNKNOWN__" }
            ,{ 1509, "__UNKNOWN__" }
            ,{ 1510, "__UNKNOWN__" }
            ,{ 1511, "__UNKNOWN__" }
            ,{ 1512, "__UNKNOWN__" }
            ,{ 1513, "__UNKNOWN__" }
            ,{ 1514, "__UNKNOWN__" }
            ,{ 1515, "__UNKNOWN__" }
            ,{ 1516, "__UNKNOWN__" }
            ,{ 1517, "__UNKNOWN__" }
            ,{ 1518, "__UNKNOWN__" }
            ,{ 1519, "__UNKNOWN__" }
            ,{ 1520, "__UNKNOWN__" }
            ,{ 1521, "__UNKNOWN__" }
            ,{ 1522, "__UNKNOWN__" }
            ,{ 1523, "__UNKNOWN__" }
            ,{ 1524, "__UNKNOWN__" }
            ,{ 1525, "__UNKNOWN__" }
            ,{ 1526, "__UNKNOWN__" }
            ,{ 1527, "__UNKNOWN__" }
            ,{ 1528, "Kulu-Ya-Ku Hide" }
            ,{ 1529, "Kulu-Ya-Ku Beak" }
            ,{ 1530, "Kulu-Ya-Ku Plume" }
            ,{ 1531, "__UNKNOWN__" }
            ,{ 1532, "__UNKNOWN__" }
            ,{ 1533, "__UNKNOWN__" }
            ,{ 1534, "Pukei-Pukei Scale" }
            ,{ 1535, "Pukei-Pukei Sac" }
            ,{ 1536, "Pukei-Pukei Tail" }
            ,{ 1537, "__UNKNOWN__" }
            ,{ 1538, "__UNKNOWN__" }
            ,{ 1539, "__UNKNOWN__" }
            ,{ 1540, "__UNKNOWN__" }
            ,{ 1541, "__UNKNOWN__" }
            ,{ 1542, "__UNKNOWN__" }
            ,{ 1543, "__UNKNOWN__" }
            ,{ 1544, "__UNKNOWN__" }
            ,{ 1545, "__UNKNOWN__" }
            ,{ 1546, "__UNKNOWN__" }
            ,{ 1547, "__UNKNOWN__" }
            ,{ 1548, "__UNKNOWN__" }
            ,{ 1549, "Tetsucabra Scale" }
            ,{ 1550, "Paddock Oil" }
            ,{ 1551, "Tetsucabra Tusks" }
            ,{ 1552, "__UNKNOWN__" }
            ,{ 1553, "__UNKNOWN__" }
            ,{ 1554, "__UNKNOWN__" }
            ,{ 1555, "__UNKNOWN__" }
            ,{ 1556, "__UNKNOWN__" }
            ,{ 1557, "__UNKNOWN__" }
            ,{ 1558, "__UNKNOWN__" }
            ,{ 1559, "__UNKNOWN__" }
            ,{ 1560, "__UNKNOWN__" }
            ,{ 1561, "__UNKNOWN__" }
            ,{ 1562, "__UNKNOWN__" }
            ,{ 1563, "__UNKNOWN__" }
            ,{ 1564, "Duramboros Shell" }
            ,{ 1565, "Duramboros Horn" }
            ,{ 1566, "Duramboros Tailbone" }
            ,{ 1567, "__UNKNOWN__" }
            ,{ 1568, "__UNKNOWN__" }
            ,{ 1569, "__UNKNOWN__" }
            ,{ 1570, "__UNKNOWN__" }
            ,{ 1571, "__UNKNOWN__" }
            ,{ 1572, "__UNKNOWN__" }
            ,{ 1573, "__UNKNOWN__" }
            ,{ 1574, "__UNKNOWN__" }
            ,{ 1575, "__UNKNOWN__" }
            ,{ 1576, "__UNKNOWN__" }
            ,{ 1577, "__UNKNOWN__" }
            ,{ 1578, "__UNKNOWN__" }
            ,{ 1579, "Anjanath Scale" }
            ,{ 1580, "__UNKNOWN__" }
            ,{ 1581, "__UNKNOWN__" }
            ,{ 1582, "__UNKNOWN__" }
            ,{ 1583, "__UNKNOWN__" }
            ,{ 1584, "__UNKNOWN__" }
            ,{ 1585, "__UNKNOWN__" }
            ,{ 1586, "__UNKNOWN__" }
            ,{ 1587, "__UNKNOWN__" }
            ,{ 1588, "__UNKNOWN__" }
            ,{ 1589, "__UNKNOWN__" }
            ,{ 1590, "__UNKNOWN__" }
            ,{ 1591, "__UNKNOWN__" }
            ,{ 1592, "__UNKNOWN__" }
            ,{ 1593, "__UNKNOWN__" }
            ,{ 1594, "Paolumu Pelt" }
            ,{ 1595, "Paolumu Webbing" }
            ,{ 1596, "Paolumu Shell" }
            ,{ 1597, "__UNKNOWN__" }
            ,{ 1598, "__UNKNOWN__" }
            ,{ 1599, "__UNKNOWN__" }
            ,{ 1600, "__UNKNOWN__" }
            ,{ 1601, "__UNKNOWN__" }
            ,{ 1602, "__UNKNOWN__" }
            ,{ 1603, "__UNKNOWN__" }
            ,{ 1604, "__UNKNOWN__" }
            ,{ 1605, "__UNKNOWN__" }
            ,{ 1606, "__UNKNOWN__" }
            ,{ 1607, "__UNKNOWN__" }
            ,{ 1608, "__UNKNOWN__" }
            ,{ 1609, "__UNKNOWN__" }
            ,{ 1610, "__UNKNOWN__" }
            ,{ 1611, "__UNKNOWN__" }
            ,{ 1612, "__UNKNOWN__" }
            ,{ 1613, "__UNKNOWN__" }
            ,{ 1614, "__UNKNOWN__" }
            ,{ 1615, "__UNKNOWN__" }
            ,{ 1616, "__UNKNOWN__" }
            ,{ 1617, "__UNKNOWN__" }
            ,{ 1618, "__UNKNOWN__" }
            ,{ 1619, "__UNKNOWN__" }
            ,{ 1620, "__UNKNOWN__" }
            ,{ 1621, "__UNKNOWN__" }
            ,{ 1622, "__UNKNOWN__" }
            ,{ 1623, "__UNKNOWN__" }
            ,{ 1624, "__UNKNOWN__" }
            ,{ 1625, "__UNKNOWN__" }
            ,{ 1626, "__UNKNOWN__" }
            ,{ 1627, "__UNKNOWN__" }
            ,{ 1628, "__UNKNOWN__" }
            ,{ 1629, "__UNKNOWN__" }
            ,{ 1630, "__UNKNOWN__" }
            ,{ 1631, "__UNKNOWN__" }
            ,{ 1632, "__UNKNOWN__" }
            ,{ 1633, "__UNKNOWN__" }
            ,{ 1634, "__UNKNOWN__" }
            ,{ 1635, "__UNKNOWN__" }
            ,{ 1636, "__UNKNOWN__" }
            ,{ 1637, "__UNKNOWN__" }
            ,{ 1638, "__UNKNOWN__" }
            ,{ 1639, "__UNKNOWN__" }
            ,{ 1640, "__UNKNOWN__" }
            ,{ 1641, "__UNKNOWN__" }
            ,{ 1642, "__UNKNOWN__" }
            ,{ 1643, "__UNKNOWN__" }
            ,{ 1644, "__UNKNOWN__" }
            ,{ 1645, "__UNKNOWN__" }
            ,{ 1646, "__UNKNOWN__" }
            ,{ 1647, "__UNKNOWN__" }
            ,{ 1648, "__UNKNOWN__" }
            ,{ 1649, "__UNKNOWN__" }
            ,{ 1650, "__UNKNOWN__" }
            ,{ 1651, "__UNKNOWN__" }
            ,{ 1652, "White Dress" }
            ,{ 1653, "__UNKNOWN__" }
            ,{ 1654, "__UNKNOWN__" }
            ,{ 1655, "__UNKNOWN__" }
            ,{ 1656, "__UNKNOWN__" }
            ,{ 1657, "__UNKNOWN__" }
            ,{ 1658, "__UNKNOWN__" }
            ,{ 1659, "__UNKNOWN__" }
            ,{ 1660, "__UNKNOWN__" }
            ,{ 1661, "__UNKNOWN__" }
            ,{ 1662, "__UNKNOWN__" }
            ,{ 1663, "__UNKNOWN__" }
            ,{ 1664, "__UNKNOWN__" }
            ,{ 1665, "__UNKNOWN__" }
            ,{ 1666, "__UNKNOWN__" }
            ,{ 1667, "__UNKNOWN__" }
            ,{ 1668, "__UNKNOWN__" }
            ,{ 1669, "__UNKNOWN__" }
            ,{ 1670, "__UNKNOWN__" }
            ,{ 1671, "__UNKNOWN__" }
            ,{ 1672, "__UNKNOWN__" }
            ,{ 1673, "__UNKNOWN__" }
            ,{ 1674, "__UNKNOWN__" }
            ,{ 1675, "__UNKNOWN__" }
            ,{ 1676, "__UNKNOWN__" }
            ,{ 1677, "__UNKNOWN__" }
            ,{ 1678, "__UNKNOWN__" }
            ,{ 1679, "__UNKNOWN__" }
            ,{ 1680, "__UNKNOWN__" }
            ,{ 1681, "__UNKNOWN__" }
            ,{ 1682, "__UNKNOWN__" }
            ,{ 1683, "__UNKNOWN__" }
            ,{ 1684, "__UNKNOWN__" }
            ,{ 1685, "__UNKNOWN__" }
            ,{ 1686, "__UNKNOWN__" }
            ,{ 1687, "__UNKNOWN__" }
            ,{ 1688, "__UNKNOWN__" }
            ,{ 1689, "__UNKNOWN__" }
            ,{ 1690, "__UNKNOWN__" }
            ,{ 1691, "__UNKNOWN__" }
            ,{ 1692, "__UNKNOWN__" }
            ,{ 1693, "__UNKNOWN__" }
            ,{ 1694, "__UNKNOWN__" }
            ,{ 1695, "__UNKNOWN__" }
            ,{ 1696, "__UNKNOWN__" }
            ,{ 1697, "__UNKNOWN__" }
            ,{ 1698, "__UNKNOWN__" }
            ,{ 1699, "__UNKNOWN__" }
            ,{ 1700, "__UNKNOWN__" }
            ,{ 1701, "__UNKNOWN__" }
            ,{ 1702, "__UNKNOWN__" }
            ,{ 1703, "__UNKNOWN__" }
            ,{ 1704, "__UNKNOWN__" }
            ,{ 1705, "__UNKNOWN__" }
            ,{ 1706, "__UNKNOWN__" }
            ,{ 1707, "__UNKNOWN__" }
            ,{ 1708, "__UNKNOWN__" }
            ,{ 1709, "__UNKNOWN__" }
            ,{ 1710, "__UNKNOWN__" }
            ,{ 1711, "__UNKNOWN__" }
            ,{ 1712, "__UNKNOWN__" }
            ,{ 1713, "__UNKNOWN__" }
            ,{ 1714, "__UNKNOWN__" }
            ,{ 1715, "__UNKNOWN__" }
            ,{ 1716, "__UNKNOWN__" }
            ,{ 1717, "__UNKNOWN__" }
            ,{ 1718, "__UNKNOWN__" }
            ,{ 1719, "__UNKNOWN__" }
            ,{ 1720, "__UNKNOWN__" }
            ,{ 1721, "__UNKNOWN__" }
            ,{ 1722, "__UNKNOWN__" }
            ,{ 1723, "__UNKNOWN__" }
            ,{ 1724, "__UNKNOWN__" }
            ,{ 1725, "__UNKNOWN__" }
            ,{ 1726, "__UNKNOWN__" }
            ,{ 1727, "__UNKNOWN__" }
            ,{ 1728, "__UNKNOWN__" }
            ,{ 1729, "__UNKNOWN__" }
            ,{ 1730, "__UNKNOWN__" }
            ,{ 1731, "__UNKNOWN__" }
            ,{ 1732, "__UNKNOWN__" }
            ,{ 1733, "__UNKNOWN__" }
            ,{ 1734, "__UNKNOWN__" }
            ,{ 1735, "__UNKNOWN__" }
            ,{ 1736, "__UNKNOWN__" }
            ,{ 1737, "__UNKNOWN__" }
            ,{ 1738, "__UNKNOWN__" }
            ,{ 1739, "__UNKNOWN__" }
            ,{ 1740, "__UNKNOWN__" }
            ,{ 1741, "__UNKNOWN__" }
            ,{ 1742, "__UNKNOWN__" }
            ,{ 1743, "__UNKNOWN__" }
            ,{ 1744, "__UNKNOWN__" }
            ,{ 1745, "__UNKNOWN__" }
            ,{ 1746, "__UNKNOWN__" }
            ,{ 1747, "__UNKNOWN__" }
            ,{ 1748, "__UNKNOWN__" }
            ,{ 1749, "__UNKNOWN__" }
            ,{ 1750, "__UNKNOWN__" }
            ,{ 1751, "__UNKNOWN__" }
            ,{ 1752, "__UNKNOWN__" }
            ,{ 1753, "__UNKNOWN__" }
            ,{ 1754, "__UNKNOWN__" }
            ,{ 1755, "__UNKNOWN__" }
            ,{ 1756, "__UNKNOWN__" }
            ,{ 1757, "__UNKNOWN__" }
            ,{ 1758, "__UNKNOWN__" }
            ,{ 1759, "__UNKNOWN__" }
            ,{ 1760, "__UNKNOWN__" }
            ,{ 1761, "__UNKNOWN__" }
            ,{ 1762, "__UNKNOWN__" }
            ,{ 1763, "__UNKNOWN__" }
            ,{ 1764, "__UNKNOWN__" }
            ,{ 1765, "__UNKNOWN__" }
            ,{ 1766, "__UNKNOWN__" }
            ,{ 1767, "__UNKNOWN__" }
            ,{ 1768, "__UNKNOWN__" }
            ,{ 1769, "__UNKNOWN__" }
            ,{ 1770, "__UNKNOWN__" }
            ,{ 1771, "__UNKNOWN__" }
            ,{ 1772, "__UNKNOWN__" }
            ,{ 1773, "__UNKNOWN__" }
            ,{ 1774, "__UNKNOWN__" }
            ,{ 1775, "__UNKNOWN__" }
            ,{ 1776, "__UNKNOWN__" }
            ,{ 1777, "__UNKNOWN__" }
            ,{ 1778, "__UNKNOWN__" }
            ,{ 1779, "__UNKNOWN__" }
            ,{ 1780, "__UNKNOWN__" }
            ,{ 1781, "__UNKNOWN__" }
            ,{ 1782, "__UNKNOWN__" }
            ,{ 1783, "__UNKNOWN__" }
            ,{ 1784, "__UNKNOWN__" }
            ,{ 1785, "__UNKNOWN__" }
            ,{ 1786, "__UNKNOWN__" }
            ,{ 1787, "__UNKNOWN__" }
            ,{ 1788, "__UNKNOWN__" }
            ,{ 1789, "__UNKNOWN__" }
            ,{ 1790, "__UNKNOWN__" }
            ,{ 1791, "__UNKNOWN__" }
            ,{ 1792, "__UNKNOWN__" }
            ,{ 1793, "__UNKNOWN__" }
            ,{ 1794, "__UNKNOWN__" }
            ,{ 1795, "__UNKNOWN__" }
            ,{ 1796, "__UNKNOWN__" }
            ,{ 1797, "__UNKNOWN__" }
            ,{ 1798, "__UNKNOWN__" }
            ,{ 1799, "__UNKNOWN__" }
            ,{ 1800, "__UNKNOWN__" }
            ,{ 1801, "__UNKNOWN__" }
            ,{ 1802, "__UNKNOWN__" }
            ,{ 1803, "__UNKNOWN__" }
            ,{ 1804, "__UNKNOWN__" }
            ,{ 1805, "__UNKNOWN__" }
            ,{ 1806, "__UNKNOWN__" }
            ,{ 1807, "__UNKNOWN__" }
            ,{ 1808, "__UNKNOWN__" }
            ,{ 1809, "__UNKNOWN__" }
            ,{ 1810, "__UNKNOWN__" }
            ,{ 1811, "__UNKNOWN__" }
            ,{ 1812, "__UNKNOWN__" }
            ,{ 1813, "__UNKNOWN__" }
            ,{ 1814, "__UNKNOWN__" }
            ,{ 1815, "__UNKNOWN__" }
            ,{ 1816, "__UNKNOWN__" }
            ,{ 1817, "__UNKNOWN__" }
            ,{ 1818, "__UNKNOWN__" }
            ,{ 1819, "__UNKNOWN__" }
            ,{ 1820, "__UNKNOWN__" }
            ,{ 1821, "__UNKNOWN__" }
            ,{ 1822, "__UNKNOWN__" }
            ,{ 1823, "__UNKNOWN__" }
            ,{ 1824, "__UNKNOWN__" }
            ,{ 1825, "__UNKNOWN__" }
            ,{ 1826, "__UNKNOWN__" }
            ,{ 1827, "__UNKNOWN__" }
            ,{ 1828, "__UNKNOWN__" }
            ,{ 1829, "__UNKNOWN__" }
            ,{ 1830, "__UNKNOWN__" }
            ,{ 1831, "__UNKNOWN__" }
            ,{ 1832, "__UNKNOWN__" }
            ,{ 1833, "__UNKNOWN__" }
            ,{ 1834, "__UNKNOWN__" }
            ,{ 1835, "__UNKNOWN__" }
            ,{ 1836, "__UNKNOWN__" }
            ,{ 1837, "__UNKNOWN__" }
            ,{ 1838, "__UNKNOWN__" }
            ,{ 1839, "__UNKNOWN__" }
            ,{ 1840, "__UNKNOWN__" }
            ,{ 1841, "__UNKNOWN__" }
            ,{ 1842, "__UNKNOWN__" }
            ,{ 1843, "__UNKNOWN__" }
            ,{ 1844, "__UNKNOWN__" }
            ,{ 1845, "__UNKNOWN__" }
            ,{ 1846, "__UNKNOWN__" }
            ,{ 1847, "__UNKNOWN__" }
            ,{ 1848, "__UNKNOWN__" }
            ,{ 1849, "__UNKNOWN__" }
            ,{ 1850, "__UNKNOWN__" }
            ,{ 1851, "__UNKNOWN__" }
            ,{ 1852, "__UNKNOWN__" }
            ,{ 1853, "__UNKNOWN__" }
            ,{ 1854, "__UNKNOWN__" }
            ,{ 1855, "__UNKNOWN__" }
            ,{ 1856, "__UNKNOWN__" }
            ,{ 1857, "__UNKNOWN__" }
            ,{ 1858, "__UNKNOWN__" }
            ,{ 1859, "__UNKNOWN__" }
            ,{ 1860, "__UNKNOWN__" }
            ,{ 1861, "__UNKNOWN__" }
            ,{ 1862, "__UNKNOWN__" }
            ,{ 1863, "__UNKNOWN__" }
            ,{ 1864, "__UNKNOWN__" }
            ,{ 1865, "__UNKNOWN__" }
            ,{ 1866, "__UNKNOWN__" }
            ,{ 1867, "__UNKNOWN__" }
            ,{ 1868, "__UNKNOWN__" }
            ,{ 1869, "__UNKNOWN__" }
            ,{ 1870, "__UNKNOWN__" }
            ,{ 1871, "__UNKNOWN__" }
            ,{ 1872, "__UNKNOWN__" }
            ,{ 1873, "__UNKNOWN__" }
            ,{ 1874, "__UNKNOWN__" }
            ,{ 1875, "__UNKNOWN__" }
            ,{ 1876, "__UNKNOWN__" }
            ,{ 1877, "__UNKNOWN__" }
            ,{ 1878, "__UNKNOWN__" }
            ,{ 1879, "__UNKNOWN__" }
            ,{ 1880, "__UNKNOWN__" }
            ,{ 1881, "__UNKNOWN__" }
            ,{ 1882, "__UNKNOWN__" }
            ,{ 1883, "__UNKNOWN__" }
            ,{ 1884, "__UNKNOWN__" }
            ,{ 1885, "__UNKNOWN__" }
            ,{ 1886, "__UNKNOWN__" }
            ,{ 1887, "__UNKNOWN__" }
            ,{ 1888, "__UNKNOWN__" }
            ,{ 1889, "__UNKNOWN__" }
            ,{ 1890, "__UNKNOWN__" }
            ,{ 1891, "__UNKNOWN__" }
            ,{ 1892, "__UNKNOWN__" }
            ,{ 1893, "__UNKNOWN__" }
            ,{ 1894, "__UNKNOWN__" }
            ,{ 1895, "__UNKNOWN__" }
            ,{ 1896, "__UNKNOWN__" }
            ,{ 1897, "__UNKNOWN__" }
            ,{ 1898, "__UNKNOWN__" }
            ,{ 1899, "__UNKNOWN__" }
            ,{ 1900, "__UNKNOWN__" }
            ,{ 1901, "__UNKNOWN__" }
            ,{ 1902, "__UNKNOWN__" }
            ,{ 1903, "__UNKNOWN__" }
            ,{ 1904, "__UNKNOWN__" }
            ,{ 1905, "__UNKNOWN__" }
            ,{ 1906, "__UNKNOWN__" }
            ,{ 1907, "__UNKNOWN__" }
            ,{ 1908, "__UNKNOWN__" }
            ,{ 1909, "__UNKNOWN__" }
            ,{ 1910, "__UNKNOWN__" }
            ,{ 1911, "__UNKNOWN__" }
            ,{ 1912, "__UNKNOWN__" }
            ,{ 1913, "__UNKNOWN__" }
            ,{ 1914, "__UNKNOWN__" }
            ,{ 1915, "__UNKNOWN__" }
            ,{ 1916, "__UNKNOWN__" }
            ,{ 1917, "__UNKNOWN__" }
            ,{ 1918, "__UNKNOWN__" }
            ,{ 1919, "__UNKNOWN__" }
            ,{ 1920, "__UNKNOWN__" }
            ,{ 1921, "__UNKNOWN__" }
            ,{ 1922, "__UNKNOWN__" }
            ,{ 1923, "__UNKNOWN__" }
            ,{ 1924, "__UNKNOWN__" }
            ,{ 1925, "__UNKNOWN__" }
            ,{ 1926, "__UNKNOWN__" }
            ,{ 1927, "__UNKNOWN__" }
            ,{ 1928, "__UNKNOWN__" }
            ,{ 1929, "__UNKNOWN__" }
            ,{ 1930, "__UNKNOWN__" }
            ,{ 1931, "__UNKNOWN__" }
            ,{ 1932, "__UNKNOWN__" }
            ,{ 1933, "__UNKNOWN__" }
            ,{ 1934, "__UNKNOWN__" }
            ,{ 1935, "__UNKNOWN__" }
            ,{ 1936, "__UNKNOWN__" }
            ,{ 1937, "__UNKNOWN__" }
            ,{ 1938, "__UNKNOWN__" }
            ,{ 1939, "__UNKNOWN__" }
            ,{ 1940, "__UNKNOWN__" }
            ,{ 1941, "__UNKNOWN__" }
            ,{ 1942, "__UNKNOWN__" }
            ,{ 1943, "__UNKNOWN__" }
            ,{ 1944, "__UNKNOWN__" }
            ,{ 1945, "__UNKNOWN__" }
            ,{ 1946, "__UNKNOWN__" }
            ,{ 1947, "__UNKNOWN__" }
            ,{ 1948, "__UNKNOWN__" }
            ,{ 1949, "__UNKNOWN__" }
            ,{ 1950, "__UNKNOWN__" }
            ,{ 1951, "__UNKNOWN__" }
            ,{ 1952, "__UNKNOWN__" }
            ,{ 1953, "__UNKNOWN__" }
            ,{ 1954, "__UNKNOWN__" }
            ,{ 1955, "__UNKNOWN__" }
            ,{ 1956, "__UNKNOWN__" }
            ,{ 1957, "__UNKNOWN__" }
            ,{ 1958, "__UNKNOWN__" }
            ,{ 1959, "__UNKNOWN__" }
            ,{ 1960, "__UNKNOWN__" }
            ,{ 1961, "__UNKNOWN__" }
            ,{ 1962, "__UNKNOWN__" }
            ,{ 1963, "__UNKNOWN__" }
            ,{ 1964, "__UNKNOWN__" }
            ,{ 1965, "__UNKNOWN__" }
            ,{ 1966, "__UNKNOWN__" }
            ,{ 1967, "__UNKNOWN__" }
            ,{ 1968, "__UNKNOWN__" }
            ,{ 1969, "__UNKNOWN__" }
            ,{ 1970, "__UNKNOWN__" }
            ,{ 1971, "__UNKNOWN__" }
            ,{ 1972, "__UNKNOWN__" }
            ,{ 1973, "__UNKNOWN__" }
            ,{ 1974, "__UNKNOWN__" }
            ,{ 1975, "__UNKNOWN__" }
            ,{ 1976, "__UNKNOWN__" }
            ,{ 1977, "__UNKNOWN__" }
            ,{ 1978, "__UNKNOWN__" }
            ,{ 1979, "__UNKNOWN__" }
            ,{ 1980, "__UNKNOWN__" }
            ,{ 1981, "__UNKNOWN__" }
            ,{ 1982, "__UNKNOWN__" }
            ,{ 1983, "__UNKNOWN__" }
            ,{ 1984, "__UNKNOWN__" }
            ,{ 1985, "__UNKNOWN__" }
            ,{ 1986, "__UNKNOWN__" }
            ,{ 1987, "__UNKNOWN__" }
            ,{ 1988, "__UNKNOWN__" }
            ,{ 1989, "__UNKNOWN__" }
            ,{ 1990, "__UNKNOWN__" }
            ,{ 1991, "__UNKNOWN__" }
            ,{ 1992, "__UNKNOWN__" }
            ,{ 1993, "__UNKNOWN__" }
            ,{ 1994, "__UNKNOWN__" }
            ,{ 1995, "__UNKNOWN__" }
            ,{ 1996, "__UNKNOWN__" }
            ,{ 1997, "__UNKNOWN__" }
            ,{ 1998, "__UNKNOWN__" }
            ,{ 1999, "__UNKNOWN__" }
        };
    }
}
