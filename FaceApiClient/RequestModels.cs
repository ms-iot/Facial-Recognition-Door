using System;

namespace Microsoft.ProjectOxford.Face
{
    class BaseRequestData
    {
        public string Name { get; set; }
        public string UserData { get; set; }

        public BaseRequestData(string name, string userData)
        {
            Name = name;
            UserData = userData;
        }
    }

    class PersonGroupReqeustData: BaseRequestData
    {
        public PersonGroupReqeustData(string name, string userData)
            : base(name, userData)
        {

        }
    }

    class UserDataReqeustData
    {
        public string UserData { get; set; }

        public UserDataReqeustData(string userData)
        {
            UserData = userData;
        }
    }

    class CreateOrUpdataPersonRequest: BaseRequestData
    {
        public Guid[] FaceIds { get; set; }

        public CreateOrUpdataPersonRequest(string name, string userData, Guid[] faceIds)
            : base(name, userData)
        {
            FaceIds = faceIds;
        }
    }

    class URLReqestData
    {
        public string Url { get; set; }

        public URLReqestData(string url)
        {
            Url = url;
        }
    }

    class FindSimilarRequestData
    {
        public Guid FaceId { get; set; }

        public Guid[] FaceIds { get; set; }

        public FindSimilarRequestData(Guid faceId, Guid[] faceIds)
        {
            FaceId = faceId;
            FaceIds = faceIds;
        }
    }

    class GroupFaceRequestData
    {
        public Guid[] FaceIds { get; set; }

        public GroupFaceRequestData(Guid[] faceIds)
        {
            FaceIds = faceIds;
        }
    }

    class IdentificationRequestData
    {
        public Guid[] FaceIds { get; set; }
        public string PersonGroupId { get; set; }
        public int MaxNumOfCandidatesReturned { get; set; }

        public IdentificationRequestData(Guid[] faceIds, string personGroupId, int maxNumOfCandidatesReturned)
        {
            FaceIds = faceIds;
            PersonGroupId = personGroupId;
            MaxNumOfCandidatesReturned = maxNumOfCandidatesReturned;
        }
    }

    class VerificationRequestData
    {
        public Guid FaceId1 { get; set; }
        public Guid FaceId2 { get; set; }
        public VerificationRequestData(Guid faceId1, Guid faceId2)
        {
            FaceId1 = faceId1;
            FaceId2 = faceId2;
        }
    }
}
