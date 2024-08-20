/////////////////////////////////////////////////////////////////////////////////////////////////////
//
// Audiokinetic Wwise generated include file. Do not edit.
//
/////////////////////////////////////////////////////////////////////////////////////////////////////

#ifndef __WWISE_IDS_H__
#define __WWISE_IDS_H__

#include <AK/SoundEngine/Common/AkTypes.h>

namespace AK
{
    namespace EVENTS
    {
        static const AkUniqueID FOOTSTEPS_RUN = 2462760816U;
        static const AkUniqueID FOOTSTEPS_WALK = 1780308710U;
        static const AkUniqueID MUSIC_THEME = 733800440U;
        static const AkUniqueID PLAYER_EAT = 803967661U;
        static const AkUniqueID PLAYER_GRAB = 816303795U;
        static const AkUniqueID PLAYER_THROWING = 2932059033U;
    } // namespace EVENTS

    namespace STATES
    {
        namespace PLAYER_LIFE
        {
            static const AkUniqueID GROUP = 3762137787U;

            namespace STATE
            {
                static const AkUniqueID ALIVE = 655265632U;
                static const AkUniqueID DEFEATED = 2791675679U;
                static const AkUniqueID NONE = 748895195U;
            } // namespace STATE
        } // namespace PLAYER_LIFE

    } // namespace STATES

    namespace SWITCHES
    {
        namespace EATING_MATERIAL
        {
            static const AkUniqueID GROUP = 3150251081U;

            namespace SWITCH
            {
                static const AkUniqueID APPLE = 67176023U;
                static const AkUniqueID WATER_DROPLETS = 3551102352U;
            } // namespace SWITCH
        } // namespace EATING_MATERIAL

        namespace PLAYER_SPEED
        {
            static const AkUniqueID GROUP = 1062779386U;

            namespace SWITCH
            {
                static const AkUniqueID RUN = 712161704U;
                static const AkUniqueID WALK = 2108779966U;
            } // namespace SWITCH
        } // namespace PLAYER_SPEED

        namespace SURFACE_MATERIAL
        {
            static const AkUniqueID GROUP = 1230601154U;

            namespace SWITCH
            {
                static const AkUniqueID CONCRETE = 841620460U;
                static const AkUniqueID DIRT = 2195636714U;
                static const AkUniqueID GRASS = 4248645337U;
                static const AkUniqueID WOOD = 2058049674U;
            } // namespace SWITCH
        } // namespace SURFACE_MATERIAL

    } // namespace SWITCHES

    namespace GAME_PARAMETERS
    {
        static const AkUniqueID PLAYER_HEALTH = 215992295U;
        static const AkUniqueID PLAYER_MOVEMENTSPEED = 2471758783U;
    } // namespace GAME_PARAMETERS

    namespace BANKS
    {
        static const AkUniqueID INIT = 1355168291U;
        static const AkUniqueID ALL_IN_ONE = 2451497209U;
    } // namespace BANKS

    namespace BUSSES
    {
        static const AkUniqueID MASTER_AUDIO_BUS = 3803692087U;
    } // namespace BUSSES

    namespace AUDIO_DEVICES
    {
        static const AkUniqueID NO_OUTPUT = 2317455096U;
        static const AkUniqueID SYSTEM = 3859886410U;
    } // namespace AUDIO_DEVICES

}// namespace AK

#endif // __WWISE_IDS_H__
