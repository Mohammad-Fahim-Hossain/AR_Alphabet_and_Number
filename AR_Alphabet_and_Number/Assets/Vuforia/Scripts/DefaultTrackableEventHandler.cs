/*==============================================================================
Copyright (c) 2017 PTC Inc. All Rights Reserved.
Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using Vuforia;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
///
/// Changes made to this file could be overwritten when upgrading the Vuforia version.
/// When implementing custom event handler behavior, consider inheriting from this class instead.
/// </summary>
public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
    #region Declered_Variable_For_Assets

    private Scene CurrentScene;

    private GameObject A;
    private GameObject B;
    private GameObject C;
    private GameObject D;
    private GameObject E;
    private GameObject F;
    private GameObject G;
    private GameObject H;
    private GameObject I;
    private GameObject J;
    private GameObject K;
    private GameObject L;
    private GameObject M;
    private GameObject N;
    private GameObject O;
    private GameObject P;
    private GameObject Q;
    private GameObject R;
    private GameObject S;
    private GameObject T;
    private GameObject U;
    private GameObject V;
    private GameObject W;
    private GameObject X;
    private GameObject Y;
    private GameObject Z;

    private GameObject ZERO;
    private GameObject ONE;
    private GameObject TWO;
    private GameObject THREE;
    private GameObject FOUR;
    private GameObject FIVE;
    private GameObject SIX;
    private GameObject SEVEN;
    private GameObject EIGHT;
    private GameObject NINE;


    private GameObject Bangla1;
    private GameObject Bangla2;
    private GameObject Bangla3;
    private GameObject Bangla4;
    private GameObject Bangla5;
    private GameObject Bangla6;
    private GameObject Bangla7;
    private GameObject Bangla8;
    private GameObject Bangla9;
    private GameObject Bangla10;
    private GameObject Bangla11;
    private GameObject Bangla12;
    private GameObject Bangla13;
    private GameObject Bangla14;
    private GameObject Bangla15;
    private GameObject Bangla16;
    private GameObject Bangla17;
    private GameObject Bangla18;
    private GameObject Bangla19;
    private GameObject Bangla20;
    private GameObject Bangla21;
    private GameObject Bangla22;
    private GameObject Bangla23;
    private GameObject Bangla24;
    private GameObject Bangla25;
    private GameObject Bangla26;
    private GameObject Bangla27;
    private GameObject Bangla28;
    private GameObject Bangla29;
    private GameObject Bangla30;
    private GameObject Bangla31;
    private GameObject Bangla32;
    private GameObject Bangla33;
    private GameObject Bangla34;
    private GameObject Bangla35;
    private GameObject Bangla36;
    private GameObject Bangla37;
    private GameObject Bangla38;
    private GameObject Bangla39;
    private GameObject Bangla40;
    private GameObject Bangla41;
    private GameObject Bangla42;
    private GameObject Bangla43;
    private GameObject Bangla44;
    private GameObject Bangla45;
    private GameObject Bangla46;
    private GameObject Bangla47;
    private GameObject Bangla48;
    private GameObject Bangla49;
    private GameObject Bangla50;

    private GameObject Bangla_zero;
    private GameObject Bangla_one;
    private GameObject Bangla_two;
    private GameObject Bangla_three;
    private GameObject Bangla_four;
    private GameObject Bangla_five;
    private GameObject Bangla_six;
    private GameObject Bangla_seven;
    private GameObject Bangla_eight;
    private GameObject Bangla_nine;






    #endregion

    #region PROTECTED_MEMBER_VARIABLES



    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;

    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS

    private void FindingAssets()
    {

        A = GameObject.Find("A");
        B = GameObject.Find("B");
        C = GameObject.Find("C");
        D = GameObject.Find("D");
        E = GameObject.Find("E");
        F = GameObject.Find("F");
        G = GameObject.Find("G");
        H = GameObject.Find("H");
        I = GameObject.Find("I");
        J = GameObject.Find("J");
        K = GameObject.Find("K");
        L = GameObject.Find("L");
        M = GameObject.Find("M");
        N = GameObject.Find("N");
        O = GameObject.Find("O");
        P = GameObject.Find("P");
        Q = GameObject.Find("Q");
        R = GameObject.Find("R");
        S = GameObject.Find("S");
        T = GameObject.Find("T");
        U = GameObject.Find("U");
        V = GameObject.Find("V");
        W = GameObject.Find("W");
        X = GameObject.Find("X");
        Y = GameObject.Find("Y");
        Z = GameObject.Find("Z");

        ZERO = GameObject.Find("00");
        ONE = GameObject.Find("11");
        TWO = GameObject.Find("22");
        THREE = GameObject.Find("33");
        FOUR = GameObject.Find("44");
        FIVE = GameObject.Find("55");
        SIX = GameObject.Find("66");
        SEVEN = GameObject.Find("77");
        EIGHT = GameObject.Find("88");
        NINE = GameObject.Find("99");

        Bangla_zero = GameObject.Find("n0");
        Bangla_one = GameObject.Find("n1");
        Bangla_two = GameObject.Find("n2");
        Bangla_three = GameObject.Find("n3");
        Bangla_four = GameObject.Find("n4");
        Bangla_five = GameObject.Find("n5");
        Bangla_six = GameObject.Find("n6");
        Bangla_seven = GameObject.Find("n7");
        Bangla_eight = GameObject.Find("n8");
        Bangla_nine = GameObject.Find("n9");

        Bangla1 = GameObject.Find("a1");
        Bangla2 = GameObject.Find("a2");
        Bangla3 = GameObject.Find("a3");
        Bangla4 = GameObject.Find("a4");
        Bangla5 = GameObject.Find("a5");
        Bangla6 = GameObject.Find("a6");
        Bangla7 = GameObject.Find("a7");
        Bangla8 = GameObject.Find("a8");
        Bangla9 = GameObject.Find("a9");
        Bangla10 = GameObject.Find("a10");
        Bangla11 = GameObject.Find("a11");
        Bangla12 = GameObject.Find("b1");
        Bangla13 = GameObject.Find("b2");
        Bangla14 = GameObject.Find("b3");
        Bangla15 = GameObject.Find("b4");
        Bangla16 = GameObject.Find("b5");
        Bangla17 = GameObject.Find("b6");
        Bangla18 = GameObject.Find("b7");
        Bangla19 = GameObject.Find("b8");
        Bangla20 = GameObject.Find("b9");
        Bangla21 = GameObject.Find("b10");
        Bangla22 = GameObject.Find("b11");
        Bangla23 = GameObject.Find("b12");
        Bangla24 = GameObject.Find("b13");
        Bangla25 = GameObject.Find("b14");
        Bangla26 = GameObject.Find("b15");
        Bangla27 = GameObject.Find("b16");
        Bangla28 = GameObject.Find("b17");
        Bangla29 = GameObject.Find("b18");
        Bangla30 = GameObject.Find("b19");
        Bangla31 = GameObject.Find("b20");
        Bangla32 = GameObject.Find("b21");
        Bangla33 = GameObject.Find("b22");
        Bangla34 = GameObject.Find("b23");
        Bangla35 = GameObject.Find("b24");
        Bangla36 = GameObject.Find("b25");
        Bangla37 = GameObject.Find("b26");
        Bangla38 = GameObject.Find("b27");
        Bangla39 = GameObject.Find("b28");
        Bangla40 = GameObject.Find("b29");
        Bangla41 = GameObject.Find("b30");
        Bangla42 = GameObject.Find("b31");
        Bangla43 = GameObject.Find("b32");
        Bangla44 = GameObject.Find("b33");
        Bangla45 = GameObject.Find("b34");
        Bangla46 = GameObject.Find("b35");
        Bangla47 = GameObject.Find("b36");
        Bangla48 = GameObject.Find("b37");
        Bangla49 = GameObject.Find("b38");
        Bangla50 = GameObject.Find("b39");

    }

    void Update()
    {

        CurrentScene = SceneManager.GetActiveScene();


    }

    protected virtual void Start()
    {
        FindingAssets();

        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
        }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }

    #endregion // PUBLIC_METHODS

    #region PROTECTED_METHODS

    protected virtual void OnTrackingFound()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Enable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;

        // Enable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;

        // Enable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;

        if (CurrentScene.name == "EnglishAlphabet")
        {
            EnglishAlphabetTargetFound();
        }
        if (CurrentScene.name == "EnglishNumber")
        {
            EnglishNumberTargetFound();
        }

        if (CurrentScene.name == "BanglaAlphabet")
        {
            BanglaAlphabetTargetFound();
        }
        if (CurrentScene.name == "BanglaNumber")
        {
            BanglaNumberTargetFound();
        }
    }

    protected void EnglishAlphabetTargetFound()
    {

        if (mTrackableBehaviour.Trackable.Name == "A")
        {
            A.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B")
        {
            B.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "C")
        {
            C.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "D")
        {
            D.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "E")
        {
            E.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "F")
        {
            F.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "G")
        {
            G.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "H")
        {
            H.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "I")
        {
            I.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "J")
        {
            J.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "K")
        {
            K.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "L")
        {
            L.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "M")
        {
            M.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "N")
        {
            N.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "O")
        {
            O.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "P")
        {
            P.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "Q")
        {
            Q.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "R")
        {
            R.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "S")
        {
            S.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "T")
        {
            T.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "U")
        {
            U.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "V")
        {
            V.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "W")
        {
            W.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "X")
        {
            X.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "Y")
        {
            Y.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "Z")
        {
            Z.GetComponent<AudioSource>().Play();
        }


    }

    protected void EnglishNumberTargetFound()
    {

        if (mTrackableBehaviour.Trackable.Name == "0-0")
        {
            ZERO.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "0-1")
        {
            ONE.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "0-2")
        {
            TWO.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "0-3")
        {
            THREE.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "0-4")
        {
            FOUR.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "0-5")
        {
            FIVE.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "0-6")
        {
            SIX.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "0-7")
        {
            SEVEN.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "0-8")
        {
            EIGHT.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "0-9")
        {
            NINE.GetComponent<AudioSource>().Play();
        }

    }

    protected void BanglaNumberTargetFound()
    {

        if (mTrackableBehaviour.Trackable.Name == "n0")
        {
            Bangla_zero.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "n1")
        {
            Bangla_one.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "n2")
        {
            Bangla_two.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "n3")
        {
            Bangla_three.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "n4")
        {
            Bangla_four.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "n5")
        {
            Bangla_five.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "n6")
        {
            Bangla_six.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "n7")
        {
            Bangla_seven.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "n8")
        {
            Bangla_eight.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "n9")
        {
            Bangla_nine.GetComponent<AudioSource>().Play();
        }

    }

    protected void BanglaAlphabetTargetFound()
    {



        if (mTrackableBehaviour.Trackable.Name == "1")
        {
            Bangla1.GetComponent<AudioSource>().Play();
        }

        if (mTrackableBehaviour.Trackable.Name == "2")
        {
            Bangla2.GetComponent<AudioSource>().Play();
        }

        if (mTrackableBehaviour.Trackable.Name == "3")
        {
            Bangla3.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "4")
        {
            Bangla4.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "5")
        {
            Bangla5.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "6")
        {
            Bangla6.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "7")
        {
            Bangla7.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "8")
        {
            Bangla8.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "9")
        {
            Bangla9.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "10")
        {
            Bangla10.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "11")
        {
            Bangla11.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "12")
        {
            Bangla12.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "13")
        {
            Bangla13.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "14")
        {
            Bangla14.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "15")
        {
            Bangla15.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "16")
        {
            Bangla16.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "17")
        {
            Bangla17.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "18")
        {
            Bangla18.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "19")
        {
            Bangla19.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "20")
        {
            Bangla20.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "21")
        {
            Bangla21.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "22")
        {
            Bangla22.GetComponent<AudioSource>().Play();
        }


        if (mTrackableBehaviour.Trackable.Name == "23")
        {
            Bangla23.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "24")
        {
            Bangla24.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "25")
        {
            Bangla25.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "26")
        {
            Bangla26.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "27")
        {
            Bangla27.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "28")
        {
            Bangla28.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "29")
        {
            Bangla29.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "30")
        {
            Bangla30.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "31")
        {
            Bangla31.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "32")
        {
            Bangla32.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "33")
        {
            Bangla33.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "34")
        {
            Bangla34.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "35")
        {
            Bangla35.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "36")
        {
            Bangla36.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "37")
        {
            Bangla37.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "38")
        {
            Bangla38.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "39")
        {
            Bangla39.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "40")
        {
            Bangla40.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "41")
        {
            Bangla41.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "42")
        {
            Bangla42.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "43")
        {
            Bangla43.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "44")
        {
            Bangla44.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "45")
        {
            Bangla45.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "46")
        {
            Bangla46.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "47")
        {
            Bangla47.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "48")
        {
            Bangla48.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "49")
        {
            Bangla49.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "50")
        {
            Bangla50.GetComponent<AudioSource>().Play();
        }
    }


    protected virtual void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = false;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = false;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = false;
        if (CurrentScene.name == "EnglishAlphabet")
        {
            A.GetComponent<AudioSource>().Stop();
            B.GetComponent<AudioSource>().Stop();
            C.GetComponent<AudioSource>().Stop();
            D.GetComponent<AudioSource>().Stop();
            E.GetComponent<AudioSource>().Stop();
            F.GetComponent<AudioSource>().Stop();
            G.GetComponent<AudioSource>().Stop();
            H.GetComponent<AudioSource>().Stop();
            I.GetComponent<AudioSource>().Stop();
            J.GetComponent<AudioSource>().Stop();
            K.GetComponent<AudioSource>().Stop();
            L.GetComponent<AudioSource>().Stop();
            M.GetComponent<AudioSource>().Stop();
            N.GetComponent<AudioSource>().Stop();
            O.GetComponent<AudioSource>().Stop();
            P.GetComponent<AudioSource>().Stop();
            Q.GetComponent<AudioSource>().Stop();
            R.GetComponent<AudioSource>().Stop();
            S.GetComponent<AudioSource>().Stop();
            T.GetComponent<AudioSource>().Stop();
            U.GetComponent<AudioSource>().Stop();
            V.GetComponent<AudioSource>().Stop();
            W.GetComponent<AudioSource>().Stop();
            X.GetComponent<AudioSource>().Stop();
            Y.GetComponent<AudioSource>().Stop();
            Z.GetComponent<AudioSource>().Stop();
        }

        if (CurrentScene.name == "BanglaAlphabet")
        {
            Bangla1.GetComponent<AudioSource>().Stop();
            Bangla1.GetComponent<AudioSource>().Stop();
            Bangla2.GetComponent<AudioSource>().Stop();
            Bangla3.GetComponent<AudioSource>().Stop();
            Bangla4.GetComponent<AudioSource>().Stop();
            Bangla5.GetComponent<AudioSource>().Stop();
            Bangla6.GetComponent<AudioSource>().Stop();
            Bangla7.GetComponent<AudioSource>().Stop();
            Bangla8.GetComponent<AudioSource>().Stop();
            Bangla9.GetComponent<AudioSource>().Stop();
            Bangla10.GetComponent<AudioSource>().Stop();
            Bangla11.GetComponent<AudioSource>().Stop();
            Bangla12.GetComponent<AudioSource>().Stop();
            Bangla13.GetComponent<AudioSource>().Stop();
            Bangla14.GetComponent<AudioSource>().Stop();
            Bangla15.GetComponent<AudioSource>().Stop();
            Bangla16.GetComponent<AudioSource>().Stop();
            Bangla17.GetComponent<AudioSource>().Stop();
            Bangla18.GetComponent<AudioSource>().Stop();
            Bangla19.GetComponent<AudioSource>().Stop();
            Bangla20.GetComponent<AudioSource>().Stop();
            Bangla21.GetComponent<AudioSource>().Stop();
            Bangla22.GetComponent<AudioSource>().Stop();
            Bangla23.GetComponent<AudioSource>().Stop();
            Bangla24.GetComponent<AudioSource>().Stop();
            Bangla25.GetComponent<AudioSource>().Stop();
            Bangla26.GetComponent<AudioSource>().Stop();
            Bangla27.GetComponent<AudioSource>().Stop();
            Bangla28.GetComponent<AudioSource>().Stop();
            Bangla29.GetComponent<AudioSource>().Stop();
            Bangla30.GetComponent<AudioSource>().Stop();
            Bangla31.GetComponent<AudioSource>().Stop();
            Bangla32.GetComponent<AudioSource>().Stop();
            Bangla33.GetComponent<AudioSource>().Stop();
            Bangla34.GetComponent<AudioSource>().Stop();
            Bangla35.GetComponent<AudioSource>().Stop();
            Bangla36.GetComponent<AudioSource>().Stop();
            Bangla37.GetComponent<AudioSource>().Stop();
            Bangla38.GetComponent<AudioSource>().Stop();
            Bangla39.GetComponent<AudioSource>().Stop();
            Bangla40.GetComponent<AudioSource>().Stop();
            Bangla41.GetComponent<AudioSource>().Stop();
            Bangla42.GetComponent<AudioSource>().Stop();
            Bangla43.GetComponent<AudioSource>().Stop();
            Bangla44.GetComponent<AudioSource>().Stop();
            Bangla45.GetComponent<AudioSource>().Stop();
            Bangla46.GetComponent<AudioSource>().Stop();
            Bangla47.GetComponent<AudioSource>().Stop();
            Bangla48.GetComponent<AudioSource>().Stop();
            Bangla49.GetComponent<AudioSource>().Stop();
            Bangla50.GetComponent<AudioSource>().Stop();
        }

        if (CurrentScene.name == "EnglishNumber")
        {

            ZERO.GetComponent<AudioSource>().Stop();
            ONE.GetComponent<AudioSource>().Stop();
            TWO.GetComponent<AudioSource>().Stop();
            THREE.GetComponent<AudioSource>().Stop();
            FOUR.GetComponent<AudioSource>().Stop();
            FIVE.GetComponent<AudioSource>().Stop();
            SIX.GetComponent<AudioSource>().Stop();
            SEVEN.GetComponent<AudioSource>().Stop();
            EIGHT.GetComponent<AudioSource>().Stop();
            NINE.GetComponent<AudioSource>().Stop();

        }

        if (CurrentScene.name == "BanglaNumber")
        {

            Bangla_zero.GetComponent<AudioSource>().Stop();
            Bangla_one.GetComponent<AudioSource>().Stop();
            Bangla_two.GetComponent<AudioSource>().Stop();
            Bangla_three.GetComponent<AudioSource>().Stop();
            Bangla_four.GetComponent<AudioSource>().Stop();
            Bangla_five.GetComponent<AudioSource>().Stop();
            Bangla_six.GetComponent<AudioSource>().Stop();
            Bangla_seven.GetComponent<AudioSource>().Stop();
            Bangla_eight.GetComponent<AudioSource>().Stop();
            Bangla_nine.GetComponent<AudioSource>().Stop();

        }


    }

    #endregion // PROTECTED_METHODS
}